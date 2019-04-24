using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization2
{
    class Program
    {
        #region Info
        /*
        - To fix the object before you return it to the caller
            - implement the IDeserializationCallback interface
            - implement the method OnDeserialization() of this interface
            The CLR promises that if you implement this interface method OnDeserialization( )
            will be called when the entire object graph has been deserialized
        - This is a classic space/time trade-off
            by not serializing the array, you may make deserialization somewhat slower
            (time to recompute the array) and you make the file somewhat smaller
        */
        #endregion
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathBinarySerialization2_1 = Path.Combine(defaultPath, @"Files\BinarySerialization2\BinarySerialization2_1.bin");
            
            Console.WriteLine("\n---------- Creating first one with new... ----------");
            SumOf s1 = new SumOf(1, 1000);
            s1.ComputeSums();
            s1.DisplaySums();
            s1.Serialize(pathBinarySerialization2_1);

            Console.WriteLine("\n---------- Creating second one with deserialize... ----------");
            SumOf ds1 = SumOf.DeSerialize(pathBinarySerialization2_1);
            ds1.DisplaySums();

            Console.ReadLine();
        }
    }
}

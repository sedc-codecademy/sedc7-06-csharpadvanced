using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BinarySerialization2
{
    [Serializable]
    class SumOf : IDeserializationCallback
    {
        private int startNumber = 1;
        private int endNumber;
        [NonSerialized]
        private int[] theSums;

        public SumOf(int start, int end)
        {
            startNumber = start;
            endNumber = end;
        }
        public void ComputeSums()
        {
            //1,2,3, 4, 5, 6, 7, 8, 9,10
            //1,3,6,10,15,21,28,36,45,55

            int count = endNumber - startNumber + 1;
            theSums = new int[count];
            theSums[0] = startNumber;
            for (int i = 1, j = startNumber + 1; i < count; i++, j++)
            {
                theSums[i] = j + theSums[i - 1];
            }
        }
        public void DisplaySums()
        {
            foreach (int i in theSums)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
        public void Serialize(string path)
        {
            Console.Write("Serializing...");
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, this);
            Console.WriteLine("...completed");
            fileStream.Close();
        }
        public static SumOf DeSerialize(string path)
        {
            Console.Write("DeSerializing...");
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            SumOf retVal = (SumOf)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine("...completed");
            fileStream.Close();
            return retVal;
        }

        // fix up the nonserialized data
        public virtual void OnDeserialization(Object sender)
        {
            ComputeSums();
        }
    }
}

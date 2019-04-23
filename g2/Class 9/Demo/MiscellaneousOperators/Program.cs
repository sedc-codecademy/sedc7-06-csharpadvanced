using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        enum weekDays { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        struct Coordinates { int x; int y; }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class SEDCStudent : Student
        {
            public bool IsAdvanced { get; set; } = true;
        }
        static void Main(string[] args)
        {
            #region Info
            /*
            - default - A default value expression default(T) produces the default value of a type T
            - sizeof - Used to obtain the size in bytes for an unmanaged type
            - typeof - Used to obtain the System.Type object for a type known at compile-time
            - GetType() - Used to obtain the type of an expression at run-time
            - nameof - Used to obtain the simple (unqualified) string name of a variable, type, or member
            - ?? operator is called the null-coalescing operator
                it returns the left-hand operand if the operand is not null,
                otherwise it returns the right hand operand
            */
            #endregion

            #region Operator default
            //Console.WriteLine("----------- Default values ValueType -----------");
            //Console.WriteLine("int: {0}", default(int));
            //Console.WriteLine("DateTime: {0}", default(DateTime));
            //Console.WriteLine("Char: {0}", default(char));
            //Console.WriteLine("Guid: {0}", default(Guid));
            //Console.WriteLine("Enum: {0}", default(weekDays));       //Enum
            //Console.WriteLine("Struct: {0}", default(Coordinates));    //new Struct()

            //Console.WriteLine("\n----------- Default values ReferenceType (NULL) -----------");
            //Console.WriteLine("Class {0}", default(Student));
            //Console.WriteLine("object: {0}", default(object));
            //Console.WriteLine("string: {0}", default(string));
            //Console.WriteLine("Interface: {0}", default(IDisposable));
            //Console.WriteLine("Dynamic: {0}", default(dynamic));
            #endregion

            #region Operator sizeof
            //Console.WriteLine("\n----------- Sizeof in bytes -----------");
            //Console.WriteLine("bool: {0} bytes", sizeof(bool));   // Returns 1.
            //Console.WriteLine("byte: {0} bytes", sizeof(byte));  // Returns 1.
            //Console.WriteLine("sbyte: {0} bytes", sizeof(sbyte));   // Returns 1.
            //Console.WriteLine("char: {0} bytes", sizeof(char));  // Returns 2.
            //Console.WriteLine("short: {0} bytes", sizeof(short));  // Returns 2.
            //Console.WriteLine("ushort: {0} bytes", sizeof(ushort));   // Returns 2.
            //Console.WriteLine("int: {0} bytes", sizeof(int));   // Returns 4.
            //Console.WriteLine("uint: {0} bytes", sizeof(uint));  // Returns 4.
            //Console.WriteLine("float: {0} bytes", sizeof(float));   // Returns 4.
            //Console.WriteLine("long: {0} bytes", sizeof(long));     // Returns 8.
            //Console.WriteLine("ulong: {0} bytes", sizeof(ulong));    // Returns 8.
            //Console.WriteLine("double: {0} bytes", sizeof(double));   // Returns 8.
            //Console.WriteLine("decimal: {0} bytes", sizeof(decimal));  // Returns 16.
            #endregion

            #region Operator typeof
            //Console.WriteLine("\n----------- Typeof -----------");
            //Console.WriteLine("Student: {0}", typeof(Student));
            //Console.WriteLine("IDisposable: {0}", typeof(IDisposable));
            //Console.WriteLine("List<>: {0}", typeof(List<>));
            //Console.WriteLine("Dictionary<int, string>: {0}", typeof(Dictionary<int, string>));
            //Console.WriteLine("int: {0}", typeof(int));

            Student s = new Student();
            SEDCStudent sEDCStudent = new SEDCStudent();

            //Console.WriteLine("\n----------- GetType -----------");
            //Console.WriteLine("s.GetType(): {0}", s.GetType());
            //Console.WriteLine("sEDCStudent.GetType(): {0}", sEDCStudent.GetType());

            //Console.WriteLine("\n----------- TypeOf and GetType -----------");
            //Console.WriteLine("s.GetType() == typeof(Student): {0}", s.GetType() == typeof(Student));
            //Console.WriteLine("sEDCStudent.GetType() == typeof(SEDCStudent): {0}", sEDCStudent.GetType() == typeof(SEDCStudent));
            //Console.WriteLine("sEDCStudent.GetType() == typeof(Student): {0}", sEDCStudent.GetType() == typeof(Student));
            //Console.WriteLine("s.GetType() == typeof(SEDCStudent): {0}", s.GetType() == typeof(SEDCStudent));
            #endregion

            #region Operator nameof
            //Console.WriteLine("\n----------- Nameof -----------");
            //int @int = 10;
            //int myInt = 20;
            //Console.WriteLine("@int: {0}", nameof(@int));
            //Console.WriteLine("myInt: {0}", nameof(myInt));
            //Console.WriteLine("sEDCStudent: {0}", nameof(sEDCStudent));
            #endregion

            #region "Null-coalesce" operator
            //Console.WriteLine("\n----------- Null-coalesce -----------");
            //SEDCStudent sedcStud = new SEDCStudent();
            //sedcStud.Name = "Student 1";
            //SEDCStudent student = null;
            //SEDCStudent newStudent = student ?? sedcStud;
            //Console.WriteLine("New name: {0}", newStudent.Name);
            #endregion

            Console.ReadLine();
        }
    }
}

using System;

namespace MiscellaneousOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Operator default 
            ////default values for value types:
            //Console.WriteLine("int {0}",default(int));
            //Console.WriteLine("DateTime {0}",default(DateTime));
            //Console.WriteLine("Char {0}",default(char));
            //Console.WriteLine("Guid {0}",default(Guid));
            //Console.WriteLine("Enum {0}",default(WeekDays));

            //Console.WriteLine("-----------------");
            //// null defaults:
            //Console.WriteLine("Class {0}",default(Student));         
            //Console.WriteLine("object {0}",default(object));
            //Console.WriteLine("string {0}",default(string));

            #endregion

            #region Operator sizeof

            //Console.WriteLine();
            //Console.WriteLine("bool {0}", sizeof(bool));   // Returns 1.
            //Console.WriteLine("byte {0}", sizeof(byte));  // Returns 1.
            //Console.WriteLine("sbyte {0}", sizeof(sbyte));   // Returns 1.
            //Console.WriteLine("char {0}", sizeof(char));  // Returns 2.
            //Console.WriteLine("short {0}", sizeof(short));  // Returns 2.
            //Console.WriteLine("ushort {0}", sizeof(ushort));   // Returns 2.
            //Console.WriteLine("int {0}", sizeof(int));   // Returns 4.
            //Console.WriteLine("uint {0}", sizeof(uint));  // Returns 4.
            //Console.WriteLine("float {0}", sizeof(float));   // Returns 4.
            //Console.WriteLine("long {0}", sizeof(long));     // Returns 8.
            //Console.WriteLine("ulong {0}", sizeof(ulong));    // Returns 8.
            //Console.WriteLine("double {0}", sizeof(double));   // Returns 8.
            //Console.WriteLine("decimal {0}", sizeof(decimal));  // Returns 16.

            #endregion

            #region Operator typeof

            //Type type;
            //type = typeof(Student); Console.WriteLine(type);
            //type = typeof(List<>); Console.WriteLine(type);
            //type = typeof(Dictionary<int, string>); Console.WriteLine(type);
            //type = typeof(int); Console.WriteLine(type);

            //Student student1 = new Student();
            //SedcStudent sedcStudent = new SedcStudent();
            //Console.WriteLine(student1.GetType() == typeof(Student));
            //Console.WriteLine(sedcStudent.GetType() == typeof(SedcStudent));
            //Console.WriteLine(sedcStudent.GetType() == typeof(Student));
            //Console.WriteLine(student1.GetType() == typeof(SedcStudent));

            #endregion

            Student s = new Student();
            SedcStudent SedcStudent = new SedcStudent();

            #region Operator nameof

            int @int = 10;
            Console.WriteLine("The name of the vaiable @int is {0}", nameof(@int));
            Console.WriteLine(nameof(SedcStudent));

            #endregion

            #region "Exclusive OR" operator
            /*
            true ^ false // Returns true
            false ^ true // Returns true
            false ^ false // Returns false
            true ^ true // Returns false
            */
            #endregion

            #region "Null-coalesce" operator

            //SedcStudent SedcStud = new SedcStudent(); 
            //SedcStudent student = null;
            //var newStudent = student ?? SedcStud; 
            //Console.WriteLine("New is advanced? {0}",newStudent.IsAdvanced);

            #endregion
        }
    }
}
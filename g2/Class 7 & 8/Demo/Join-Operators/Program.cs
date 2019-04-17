using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Join_Operators
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CollegeID { get; set; }
    }

    public class College
    {

        public int CollegeID { get; set; }
        public string CollegeName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Info
            /*
            - Join operator operates on two collections, inner collection & outer collection
              joins two sequences (collections) based on a key
              returns a new collection that contains elements from both the collections which satisfies specified expression
              the same as inner join of SQL
            - GroupJoin operator performs the same task as Join operator except that GroupJoin returns a result in group based on specified group key
              joins two sequences (collections) based on key and groups the result by matching key and then returns the collection of grouped result and key
              like Left Outer Join of SQL
            */
            #endregion
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            Action line = () => Console.WriteLine();

            //Linq 102: This sample shows how to efficiently join elements of two sets based on equality 
            //          between key expressions over the two. Additinally filtering is done with a Where
            //          clause.
            #region Linq 102
            //var q =
            //    from c in customers
            //    join o in orders on c.CustomerID equals o.CustomerID
            //    where c.CustomerID == "VINET"
            //    select new { Customer = c.CustomerID, City = o.ShipCity, o.Freight };
            //foreach (var item in q)
            //{
            //    Console.WriteLine("Customer {0}, City {1}, Freight {2}", item.Customer, item.City, item.Freight);
            //}

            //line();

            var q2 = customers.Join(orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new { Customer = c.CustomerID, City = o.ShipCity, Freight = o.Freight, Employee = o.EmployeeID })
                .Where(c => c.Customer == "VINET");
            foreach (var item in q2)
            {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}", item.Customer, item.City, item.Freight);
            }
            #endregion


            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, CollegeID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, CollegeID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, CollegeID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, CollegeID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };
            List<College> collegeList = new List<College>() {
                new College(){ CollegeID = 1, CollegeName="Massachusetts Institute of Technology"},
                new College(){ CollegeID = 2, CollegeName="Stanford University"},
                new College(){ CollegeID = 3, CollegeName="University of California--Berkeley"}
            };
            //Linq 103 Join vs GroupJoin
            #region Linq 103
            //var joinExample = collegeList.Join(studentList,  //inner sequence
            //                    c => c.CollegeID, //outerKeySelector 
            //                    s => s.CollegeID,     //innerKeySelector
            //                    (c, s) => new // resultSelector 
            //                    {
            //                        CollegeName = c.CollegeName,
            //                        StudentID = s.StudentID,
            //                        StudentName = s.StudentName,
            //                        StudentAge = s.Age
            //                    });
            //Console.WriteLine("Join Example");
            //foreach (var item in joinExample)
            //{
            //    Console.WriteLine($"College: {item.CollegeName}, StudentID: {item.StudentID}, StudentName: {item.StudentName} ");
            //}

            ////line();

            //var groupJoinExample = collegeList.GroupJoin(studentList,  //inner sequence
            //                    c => c.CollegeID, //outerKeySelector 
            //                    s => s.CollegeID,     //innerKeySelector
            //                    (c, s) => new // resultSelector 
            //                    {
            //                        CollegeName = c.CollegeName,
            //                        Students = s
            //                    });
            //Console.WriteLine("Group Join Example");
            //foreach (var item in groupJoinExample)
            //{
            //    Console.WriteLine($"College: {item.CollegeName}");
            //    foreach (var stud in item.Students)
            //    {
            //        Console.WriteLine($"StudentID: {stud.StudentID}, StudentName: {stud.StudentName} ");
            //    }
            //}
            #endregion

            Console.ReadLine();
        }   

    }
}

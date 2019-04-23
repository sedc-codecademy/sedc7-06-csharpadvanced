using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework scripts - SORT by application version

            //var scripts = new List<DBScript>()
            //{
            //    new DBScript("5.1.3.9_UpdatingTablesForUsers"),
            //    new DBScript("5.1.2.8_UpdatingIndexesForTables"),
            //    new DBScript("5.9.10.4_InsertingNewUsers"),
            //    new DBScript("5.10.6.7_RemovingDependenciesOnNewUsers"),
            //    new DBScript("5.1.6.8_AddingUsersInfo"),
            //    new DBScript("5.9.3.2_CalculatingUsersAddresses"),
            //    new DBScript("5.9.2.2_RemoveDuplicates"),
            //    new DBScript("5.10.1.1_InsertingUserGroups"),
            //    new DBScript("5.1.7.9_InsertingMobilePhonesInfo"),
            //    new DBScript("5.2.7.10_InsertingExamResults"),
            //    new DBScript("5.9.8.12_GroupingExamResults"),
            //    new DBScript("5.10.8.11_CheckDBForConsistency")
            //};

            var scripts = new List<DBScript>()
            {
                new DBScript("5_1_UpdatingTablesForUsers"),
                new DBScript("5_2_UpdatingTablesForUsers"),
                new DBScript("5_9_UpdatingTablesForUsers"),
                new DBScript("5_10_UpdatingTablesForUsers")
            };

            scripts.Sort();
        }
    }
}
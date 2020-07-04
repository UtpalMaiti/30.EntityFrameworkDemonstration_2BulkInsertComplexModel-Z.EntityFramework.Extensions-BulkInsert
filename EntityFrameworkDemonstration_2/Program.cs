using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstration_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<TestTable> list = new List<TestTable>();

            for (int i = 1; i <= 5000; i++)
            {
                TestTable t = new TestTable
                {
                    Id = i,
                    FirstName = "Name - " + i
                };

                list.Add(t);
            }

            Stopwatch sw = new Stopwatch();

            sw.Start();

            //MyOrgDBEntities dbContext = new MyOrgDBEntities();

            //dbContext.TestTables.AddRange(list);

            //dbContext.SaveChanges();

            MyOrgDBEntities dbContext = new MyOrgDBEntities();

            //Bulk Operation
            dbContext.TestTables.BulkInsert(list);
            //dbContext.BulkInsert(list);

            //dbContext.TestTables.b

            dbContext.BulkSaveChanges();

            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            //EmployeeTable e1 = new EmployeeTable
            //{
            //    Name="Test Name",LastName="Last Name",Location="Bangalore",Salary=12345,
            //    EmployeeAddressTable=new EmployeeAddressTable
            //    {
            //        AddressLine1="Line 1",AddressLine2="Line 2",City="Bangalore",
            //        State ="Karnataka"
            //    }
            //};
            //Console.WriteLine("Welcome to Employee Registration Screen");

            //EmployeeTable et = new EmployeeTable();

            //Console.WriteLine("Please Enter Employee Name");
            //et.Name = Console.ReadLine();

            //Console.WriteLine("Please Enter Employee Last Name");
            //et.LastName = Console.ReadLine();

            //Console.WriteLine("Please Enter Employee Location");
            //et.Location = Console.ReadLine();

            //Console.WriteLine("Please Enter Employee Salary");
            //et.Salary = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Employee Address Line 1");

            //EmployeeAddressTable address = new EmployeeAddressTable();
            //address.AddressLine1 = Console.ReadLine();

            //Console.WriteLine("Please Enter Address Line 2");
            //address.AddressLine2 = Console.ReadLine();

            //Console.WriteLine("Please Enter City");
            //address.City = Console.ReadLine();

            //Console.WriteLine("Please Enter State");
            //address.State = Console.ReadLine();

            //MyOrgDBEntities dbContext = new MyOrgDBEntities();
            ////dbContext.EmployeeTables.Add(et);
            //dbContext.Entry(et).State = System.Data.Entity.EntityState.Added;

            //Console.WriteLine("Employee ID before SaveChanges : "+et.EmployeeId);

            //et.EmployeeAddressTable = address;

            //dbContext.SaveChanges();

            //Console.WriteLine("Employee ID after SaveChanges : "+et.EmployeeId);

            //address.EmployeeId = et.EmployeeId;

            //dbContext.EmployeeAddressTables.Add(address);

            //dbContext.SaveChanges();
        }
    }
}
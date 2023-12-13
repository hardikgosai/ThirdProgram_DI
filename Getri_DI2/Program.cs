using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getri_DI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Hardik", 20, new Department(1, "IT"));
            Console.Write($" Department Id: {employee1.department.DeptId} Department Name: {employee1.department.DeptName}");
            Console.WriteLine();
            Employee employee2 = new Employee(2, "Saurabh", 25, new Department(2, "HR"));
            Console.Write($" Department Id: {employee2.department.DeptId} Department Name: {employee2.department.DeptName}");
            Console.WriteLine();
            Employee employee3 = new Employee(3, "Pratik", 30, new Department(3, "Tech"));
            Console.Write($" Department Id: {employee3.department.DeptId} Department Name: {employee3.department.DeptName}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }


    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public Department department;

        public Employee(int _EmpId, string _EmpName, int _EmpAge, Department _department)
        {            
            EmpId = _EmpId;
            EmpName = _EmpName;
            EmpAge = _EmpAge;
            department = _department;
            Console.Write($"Employee Id: {EmpId} Employee Name: {EmpName} Employee Age: {EmpAge}");
        }
    }

    public class Department
    {
        public int DeptId { get; set;}
        public string DeptName { get; set; }

        public Department(int _DeptId, string _DeptName)
        {
            DeptId = _DeptId;
            DeptName = _DeptName;

            //Console.WriteLine($"Department Id: {DeptId} Department Name: {DeptName}");
        }
    }
}

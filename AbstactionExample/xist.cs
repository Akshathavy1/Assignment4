using System;


namespace AbstactionExample
{
    public class Employee
    {
        public void  checkEmployeeDetails(int empid)
        {
            IsEmployeeExists( empid);
            DeleteEmployee(empid);
        }
        private bool IsEmployeeExists(int empid)
        {
            return true;
        }
        private bool DeleteEmployee(int empid)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Employee obj=new Employee();

            obj.checkEmployeeDetails(100);
            Console.Read();
        }
    }
}

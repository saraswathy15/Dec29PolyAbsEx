using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public class Employee
    {
        private int id; private string name;
        public Employee(int Id, string Name)
        { this.id = Id; this.name = Name; }
        public Employee(Employee emp)//copy constructor
        { id = emp.id; name = emp.name; }
        public string Show { get { return "Employee id  " + id + "  name is  " + name; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(201, "Saru");
            Employee e2 = new Employee(e1);//calling copy , e2 is taking values from e1 instance
            string msg = e2.Show;
            Console.WriteLine(msg);
            //  Product pd = new Product();
        }
        public class Product { static int x = 10; private Product() { Console.WriteLine(x); } }
        // public class Pp: Product { }
    }
}

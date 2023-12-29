using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public interface First { void Fun1(); }
    public interface Second { void Fun2(); }
    public interface Third { void Fun3(); }
    internal class Class1 : First, Second, Third
    {
        public void Fun1() { Console.WriteLine(" from first interface"); }
        public void Fun2() { Console.WriteLine("from second interface"); }
        public void Fun3() { Console.WriteLine("from third interface "); }
        static void Main(string[] args)
        {
            First f = new Class1(); f.Fun1();
            Second s = new Class1(); s.Fun2();
            Third t = new Class1(); t.Fun3();
        }
    }
}
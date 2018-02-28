using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region comments


            //int[] arr = new int[] { 2,1,7,6,8,5,3,4 };

            //int result=sort(ref arr);
            //var s1 = "vishnu";
            //HashmapList<string, string> Hashmaplist = new HashmapList<string, string>();

            //var Mylist =new ArrayList { "cat", "acre","tac","care"};


            //foreach (string item in Mylist)
            //{
            //    char[] key = item.ToArray();
            //    Array.Sort(key);
            //    Hashmaplist.add(new string(key), item);
            //}
            ////added each elemnent to hashmaplist

            ////read every element and assign it to array
            //Mylist.Clear();
            //foreach (string item in Hashmaplist.getKeys())
            //{
            //    ArrayList alist=Hashmaplist.get(item);

            //    foreach (var element in alist)
            //    {
            //        Mylist.Add(element);
            //    }

            //}


            //foreach (var item in Mylist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //B b = new B();
            //b.DoWork();

            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee());
            emps.Add(new PartTimeEmployee());
            emps.Add(new FullTimeEmployee());
            emps.Add(new TemporaryEmployee());


            foreach (var emp in emps)
            {
                emp.PrintFullName();
            }

            Console.ReadLine();
        }
    }


    class A
    {
        public void DoWork()
        { Console.WriteLine("DoWorkk in A"); }
    }
    class B:A
    {
        public void DoWork()
        { Console.WriteLine("DoWorkk in B"); }
    }


    abstract class one
    {
        public abstract void dowork1();
        public void dowork11() { Console.WriteLine("dowkr11"); }
    }
    class two : one
    {
        public override void dowork1()
        {
            Console.WriteLine("in class2 dowkr1");
        }
        public void dowork11() {
            base.dowork11();
            Console.WriteLine("inclass2 dowrk11"); }
        public extern void method3() ;
    }
    class three : IFour<three>
    {
        public void doFour()
        {
            throw new NotImplementedException();
        }
    }
    interface IFour<T>
    {
         void doFour();
    }

    interface IDimension
    {
        int getLenght();
        int getWidth();
    }

    class Box : IDimension
    {
        int IDimension.getLenght()
        {
            return 4;
        }

        int IDimension.getWidth()
        {
            return 6;
        }
    }
}

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

            //int[] arr = new int[] { 2,1,7,6,8,5,3,4 };

            //int result=sort(ref arr);
            //var s1 = "vishnu";
            HashmapList<string, string> Hashmaplist = new HashmapList<string, string>();

            var Mylist =new ArrayList { "cat", "acre","tac","care"};
            

            foreach (string item in Mylist)
            {
                char[] key = item.ToArray();
                Array.Sort(key);
                Hashmaplist.add(new string(key), item);
            }
            //added each elemnent to hashmaplist

            //read every element and assign it to array
            Mylist.Clear();
            foreach (string item in Hashmaplist.getKeys())
            {
                ArrayList alist=Hashmaplist.get(item);
                
                foreach (var element in alist)
                {
                    Mylist.Add(element);
                }

            }


            foreach (var item in Mylist)
            {
                Console.WriteLine(item);
            }
        }




        

    }



   
}

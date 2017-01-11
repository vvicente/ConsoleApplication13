using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13 {
    class Program {
        static void Main(string[] args)
        {

            UseParams(1, 2, 3, 4);

            UseParamsString("we can pass", "a variable", "number of arguments"); //3
            UseParamsString("four", "...", "if we", "want to");                     //4
            UseParamsString("Or maybe", "two");                     //2
            UseParamsString("you name it");                         //1



            #region OptionalParameters
            //OptionalParameters("this is mandatory");
            //OptionalParameters("this is mandatory", "this is optional");


            ////OptParam(1, , 2);
            //OptParam(1, 2, 3);
            #endregion
            #region OutTest
            //string str;
            //int i;
            //string str2 = "";

            //OutReturn(out str);
            //Console.WriteLine(str);

            //MultiOutReturn(out i, out str);
            //Console.WriteLine("{0} {1}", i, str);

            //string str3 = CombinedReturn2(out i, ref str2);
            //Console.WriteLine("{0} {1}\n{2}", i, str2, str3);

            #endregion
            #region RefTest
            //string str1 = "";
            //int i = 0;
            //ReturnRef(ref str1);
            //Console.WriteLine(str1);

            //MultiRefReturn(ref i, ref str1);
            //Console.WriteLine("{0} {1}", i, str1);

            //string str2 = CombinedReturn(ref i, ref str1);
            //Console.WriteLine("{0} {1}\n{2}", i, str1, str2);
            #endregion
            #region ReturnTest
            //int added = Add(2, 4);

            //Console.WriteLine(added);
            //Console.WriteLine(Add(4, 7));
            //Console.WriteLine(Concat("Hello ", "World!!!"));
            //List<int> l = CreateList();

            //Console.WriteLine(l[0]);
            #endregion
            Console.ReadLine();

        }

        #region Methods
        public static int Add(int x, int y)
        {
            int z = x + y;
            int k;
            //return x + y;           //valid
            //return z;             //valid
            return k = x + y;
            //return x + return y;  //not valid
        }

        public static string Concat(string str1, string str2)
        {
            string str3 = str1 + str2;
            return str3;
        }

        public static List<int> CreateList()
        {
            int k = 7;
            List<int> list = new List<int>();
            list.Add(k);
            return list;
        }

        public static void ReturnRef(ref string refToReturn)
        {
            refToReturn = "This string was returned using the ref keyword";
        }

        public static void MultiRefReturn(ref int i, ref string str)
        {
            i = 142;
            str = "String to Return with Ref";
        }

        public static string CombinedReturn(ref int i, ref string str)
        {
            i = 777;
            str = "Just another string… nothing special”";

            return "yet another string";
        }

        public static void OutReturn(out string str)
        {
            str = "Returned by out";
        }

        public static void MultiOutReturn(out int i, out string str)
        {
            i = 777;
            str = "Another one returned by out";
        }

        public static string CombinedReturn2(out int i, ref string str)
        {
            i = 777;                                //mandatory
            str = "string to return";              //optional
            return "another string to return";      //mandatory
        }

        public static void OptionalParameters(string mandatory, string optional = "default string")
        {
            Console.WriteLine("Mandatory: " + mandatory);
            Console.WriteLine("Optional: " + optional);
        }

        public static void OptParam(int i, int k = 1, int x = 2)
        {
            Console.WriteLine("Do stuff");
        }

        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void UseParamsString(params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        #endregion
    }
}

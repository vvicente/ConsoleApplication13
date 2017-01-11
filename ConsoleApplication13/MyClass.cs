using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13 {
    class MyClass {
        public int MyInt { get; set; }
        public string MyString { get; set; }

        private string other;

        public int Dss { get; } = 80;

        public String Other
        {
            set { other = value; Console.WriteLine(value); }
        }


        public MyClass (string str, int i){
            this.MyInt = i;
            this.MyString = str;
        }

        public string test()
        {
            return "this is a test";
        }

        public string test(int x)
        {
            return "777";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaNetCore
{
    //https://www.w3cschool.cn/csharp/csharp-delegates.html
    public class DelegatesClass
    {
        delegate void TestDelegate(string s);
        public void M(string s)
        {
            Console.WriteLine(s);
        }
        public void Main()
        {
            //original 
            TestDelegate tsA = new TestDelegate(M);
            //C#2.0
            TestDelegate tsB = delegate (string s) { Console.WriteLine(s); };
            //C# 3.0
            TestDelegate tsC = (s) => { Console.WriteLine(s); };
        }
    }
}

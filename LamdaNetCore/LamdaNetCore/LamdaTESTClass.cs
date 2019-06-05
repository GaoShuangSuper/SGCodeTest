using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaNetCore
{
    public class LamdaTESTClass
    {
        public void Method1()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("1", "a");
            dictionary.Add("2", "b");
            dictionary.Add("3", "c");
            dictionary.Add("4", "d");
            foreach (string key in dictionary.Keys)
            {              
                Console.WriteLine(key,dictionary[key]);
            }          
        }
    }
}

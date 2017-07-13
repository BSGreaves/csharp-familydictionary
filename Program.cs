using System;
using System.Collections.Generic;

namespace familydictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterate over each item in myFamily and produce the following output.
            //Krista is my sister and is 42 years old

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("Brother", new Dictionary<string, string>(){ 
                {"name", "Anthony"},
                {"age", "24"}
            });
            myFamily.Add("Mother", new Dictionary<string, string>(){ 
                {"name", "Susan"},
                {"age", "53"}
            });
            myFamily.Add("Father", new Dictionary<string, string>(){ 
                {"name", "Peter"},
                {"age", "54"}
            });
            
            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine("{0} is my {1} and is {2} years old",  member.Value["name"], member.Key, member.Value["age"]);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("Sister", new Dictionary<string, string>(){ { "name", "Ayumi" }, { "occupation", "plumber"} });
            myFamily.Add("Brother", new Dictionary<string, string>() { { "name", "Norihito" }, { "occupation", "web developer" } });
            myFamily.Add("Father", new Dictionary<string, string>() { { "name", "Shichiro" }, { "occupation", "chef" } });
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Maruko" }, { "occupation", "housewife" } });
            myFamily.Add("Husband", new Dictionary<string, string>() { { "name", "Robert" }, { "occupation", "shipping manager" } });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is a {item.Value["occupation"]}");
            }
        }
    }
}

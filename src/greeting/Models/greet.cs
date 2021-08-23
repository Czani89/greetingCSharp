using System;
using System.Collections.Generic;

namespace greeting.Models
{
    public class Greet
    {
        public static int NameId { get; set; }
        public static string Name {get; set;}
        public static string Language {get; set;}
        public static Dictionary<string, int> nameCollection = new Dictionary<string, int>();
        public int Counter{get; set;}
        public string ErrorMessage{get; set;}
        public string GreetMessage{get; set;}
        
        public int myCounter()
        {
            return nameCollection.Count;
        }

        public void GreetMe(string name, string greeting)
        {
            if (string.IsNullOrEmpty(name))
            {
                ErrorMessage = "Enter a valid name.";

            } else if(string.IsNullOrEmpty(greeting))
            {
                ErrorMessage = "Please select language.";
            }else if(string.IsNullOrEmpty(name) && string.IsNullOrEmpty(greeting))
            {
                ErrorMessage = "Please select language and enter a valid name.";
            }else
            {
                GreetPerson(name, greeting);

            }
        }
        private void GreetPerson(string name, string greeting)
        {
            if (greeting == "xhosa")
            {
                GreetMessage = $"Molo, {name}.";
            }
            else if (greeting == "english")
            {
                GreetMessage = $"Hello, {name}.";
            }
            else if (greeting == "afrikaans")
            {
                GreetMessage = $"Halo, {name}.";
            }
            NameCounter(name);
        }

        private void NameCounter(string name)
        {
            if (!nameCollection.ContainsKey(name))
            {
                nameCollection.Add(name, 1);
            }
            else if (nameCollection.ContainsKey(name))
            {
                nameCollection[name]++;
            }
            Counter = nameCollection.Count;
        }
    }

}
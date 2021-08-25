using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Buisness
    {
        public string CalculBusiness(int i)
        {
            return $"La réponse est {i*2}";
        }
    }

    public class Question
    {
        public List<string> elements;

        public override string ToString()
        {
            string result = $"{elements[0]} <br />";
            for (int i = 1; i < elements.Count - 1; i++)
                result += $"{i}. {elements[i]}<br />";
            return result;
        }


    }
}

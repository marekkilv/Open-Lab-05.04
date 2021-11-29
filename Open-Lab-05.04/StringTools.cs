using System;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
           Regex rgx = new Regex("[^A-Za-z0-9 -]");
            string new_string = string.Empty;
            for (int i = 0; i <= original.Length-1; i++)
            {
                if (!rgx.IsMatch(original[i].ToString()))
                {
                    new_string += original[i];
                }
            }
            return new_string;
        }
    }
}

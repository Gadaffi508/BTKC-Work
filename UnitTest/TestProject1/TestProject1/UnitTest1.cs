using System;
namespace TestProject1
{
    public class Tests
    {
        public static string VerySpaceDeleted(string ifade)
        {
            ifade = ifade.Trim();

            string newStr = string.Empty;

            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i]== ' ' && ifade[i+1] == ' ')
                {
                    continue;

                    newStr += ifade[i];
                }
            }
            return newStr;
        }
    }
}
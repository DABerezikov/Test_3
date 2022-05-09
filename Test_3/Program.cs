using System;
using System.Collections.Generic;

namespace Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s = Console.ReadLine();
           string t = Console.ReadLine();
           string [] result = new string[s.Length];
           bool[] check = new bool[s.Length];
           
            
            for (int i = 0; i < s.Length; i++)
            {

                if (t[i]==s[i])
                {
                    result[i] = "G";
                    check[i] = true;
                    
                }                            

            }
            for (int indexT = 0; indexT < t.Length; indexT++)
            {
                for (int indexS = 0; indexS < s.Length; indexS++)
                {
                    if (check[indexS] == false && t[indexT] == s[indexS] && result[indexT] != "G")
                    {
                        result[indexT] = "Y";
                        check[indexS] = true;
                        break;
                    }                  
                    
                }

                if (result[indexT] != "G" && result[indexT] != "Y")
                {
                    result[indexT] = ".";

                }
            }
            foreach (var item in result)
            {
                Console.Write(item);
            }
                        
        }
    }
}

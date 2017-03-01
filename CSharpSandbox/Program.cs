using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CSharpSandbox
{
    class Program
    {
       

        static void Main(string[] args)
        {
     
        }
   
        #region EnumTest

        public class TestEnumClass
        {
            public void Main()
            {
                var dictonary = new Dictionary<CMD, List<string>>();
                var names = Enum.GetNames(typeof(CMD));
                foreach (var name in names)
                {
                    var value = (CMD)Enum.Parse(typeof(CMD), name);
                    if (!dictonary.ContainsKey(value))
                        dictonary.Add(value, new List<string> { name });
                    else
                        dictonary[value].Add(name);
                }

                var sb = new StringBuilder();

                dictonary.ToList().ForEach(x => sb.AppendLine(string.Join(",", x.Value)));

                Console.WriteLine(sb.ToString());
            }

            enum CMD
            {
                COMMANDS, CMD = 0,
                ONE, O = 1,
                TWO, T = 2,
                THREE, TH = 3,
                FOUR, F = 4,
                FIVE, FI = 5,
                SIX, S = 6,
                SEVEN, SE = 7
            }
        }

        #endregion
    }
}

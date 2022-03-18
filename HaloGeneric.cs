using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302201131
{
    public class HaloGeneric <T>
    {
       static void SapaUser <T>(ref T lhs, ref T rhs)
       {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private static void SapaUser(ref string x)
        {
            throw new NotImplementedException();
            Console.WriteLine("Halo user X");
        }

        static void Main (string[] args)
        {
            Console.WriteLine("Tasy");
        }

        }
    }


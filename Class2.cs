using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public void test1(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a is bigger");
            }
            else
            {
                Console.WriteLine("b is bigger");
            }

        }
    }
    class mainprg
    {
        static void Main()
        {
            Class2 obj = new Class2();
            obj.test1(10, 11);

        }
    }
    
    }


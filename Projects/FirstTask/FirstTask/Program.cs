using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Results
    {
        private int phy, che, mat;
        int failed = 0;

        public void physics(int a)
        {
            if (a >= 0 & a <= 150)
            {
                phy = a;
            }
            else
            {
                phy = 151;
                Console.Write("Invalid phy marks");
            }

            if (a < 90)
            {
                failed++;
            }

        }

        public void chemistry(int a)
        {
            if (a >= 0 & a <= 150)
            {
                che = a;
            }
            else
            {
                che = 151;
                Console.WriteLine("Invalid che marks");
            }

            if (a < 90)
            {
                failed++;
            }
        }

        public void maths(int a)
        {
            if (a >= 0 & a <= 150)
            {
                mat = a;
            }
            else
            {
                mat = 151;
                Console.Write("Invalid mat marks");
            }

            if (a < 90)
            {
                failed++;
            }
        }

        public void showResults()
        {
            int total;
            float per;

            if (phy == 151 || che == 151 || mat == 151)
            {
                Console.Write("No valid results");
            }

            else if (failed == 0)
            {
                total = phy + che + mat;

                per = (float)total * 100 / 450;

                Console.Write("Total Marks : " + total + "\n");
                Console.Write("Total Percentage: " + per + "\n");

            }
            else if (failed == 1)
            {
                Console.Write("Redo Exam");
            }
            else if (failed == 2)
            {
                Console.Write("Redo course");
            }
            else if (failed == 3)
            {
                Console.Write("Go home");
            }

        }
    }

    class Program { 
        static void Main(string[] args)
        {
            Results peter, smith;
            peter = new Results();
            smith = new Results();

            peter.physics(98);
            peter.chemistry(98);
            peter.maths(123);

             peter.showResults();
            //smith.showResults();
            Console.Read();
        }
        //
  }
}

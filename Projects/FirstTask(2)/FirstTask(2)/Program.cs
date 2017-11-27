using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask_2_
{
    class Results
    {
        private int phy, che, mat;
        int failed;

        public int physics
        {
            set
            {
                if (value >= 0 & value <= 150)
                {
                    phy = value;
                }
                else
                {
                    phy = -1;
                    Console.WriteLine("Invalid phy marks");
                }

                if (value < 90)
                {
                    failed++;
                }
            }

            get
            {
                return phy;
            }

        }

        public int chemistry
        {
            set
            {
                if (value >= 0 & value <= 150)
                {
                    che = value;
                }
                else
                {
                    che = -1;
                    Console.WriteLine("Invalid che marks");
                }

                if (value < 90)
                {
                    failed++;
                }
            }

            get
            {
                return che;
            }

        }
        public int maths
        {
            set
            {
                if (value >= 0 & value <= 150)
                {
                    mat = value;
                }
                else
                {
                    mat = -1;
                    Console.WriteLine("Invalid phy marks");
                }

                if (value < 90)
                {
                    failed++;
                }
            }

            get
            {
                return mat;
            }

        }

        public void showResults()
        {
            int total;
            float per;

            if (phy == -1 || che == -1 || mat == -1)
            {
                Console.WriteLine("No valid results");
            }

            else if (failed == 0)
            {
                total = phy + che + mat;

                per = (float)total * 100 / 450;

                Console.WriteLine("Total Marks : " + total);
                Console.WriteLine("Total Percentage: " + per);

            }
            else if (failed == 1)
            {
                Console.WriteLine("Redo Exam");
            }
            else if (failed == 2)
            {
                Console.WriteLine("Redo course");
            }
            else if (failed == 3)
            {
                Console.WriteLine("Go home");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Results peter;
            peter = new Results();


            peter.physics = 100;
            peter.chemistry = 100;
            peter.maths = 100;

            peter.showResults();
            Console.Read();
        }

    }
}

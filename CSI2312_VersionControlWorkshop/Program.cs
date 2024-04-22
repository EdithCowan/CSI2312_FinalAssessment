using System;
// CSI2312 - Foundations of Software Engineering
// 
// Code for the git question of the assessment - enjoy!
//
// Edith Cowan University, 2024 - Martin Masek

namespace CSI2312_FinalAssessment
{
    class Program
    {
        static void Task01(int[] data)
        {       
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        static void Task02(int[] data)
        {

        }

        static void Task03(int[] data)
        {

        }

        static void Task04(int[] data)
        {

        }

        static void Main(string[] args)
        {
            // define some data
            int[] data = { 1, 2, 3, 4, 5, 6 };
            // menu loop

            while (true)
            {
                Console.Clear();
                Console.WriteLine("This is the submission of: [YOUR NAME HERE]\n");
                int index = 0;
                Console.Write("The current data is: [");
                foreach (int x in data)
                {
                    Console.Write(x);
                    index++;
                    if (index < data.Length)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine("]\n");
                    }

                }
                Console.WriteLine("=============================");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("(1) Final Assessment");
                Console.WriteLine("(2) ----------------");
                Console.WriteLine("(3) ----------------");
                Console.WriteLine("(4) ----------------");
                Console.WriteLine("=============================");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Task01(data);
                        break;
                    case 2:
                        Task02(data);
                        break;
                    case 3:
                        Task03(data);
                        break;
                    case 4:
                        Task04(data);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}

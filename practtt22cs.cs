using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practwork2
{

    internal class Program
    {

        static void Main()
        {
            int ProgNumber;
         

            Console.WriteLine
                    ("Выберите программу,которую вы хотите использовать:");
            Console.WriteLine
               ("1. Угадай число.\n" +
                "2. Таблица Умножения.\n" +
                "3. Вывод делителя данного числа.\n" +
                "4. Выход из консоли.");

            ProgNumber = Convert.ToInt32(Console.ReadLine());
            if (ProgNumber == 1)
            {
                Random_Prog();
            }
            if (ProgNumber == 2)
            {
                Table_Of_Multiplication();
            }
            if (ProgNumber == 3)
            {
                Prog_Divider();
            }
            if (ProgNumber == 4)
            {
                Environment.Exit(0);
            }
           

            Console.ReadLine();

        }

        static void Random_Prog()
        {
          
            Console.WriteLine("Угадайте число от 0 до 100.");

            Random RandomN = new Random();
            int Random_Number = RandomN.Next(0, 100);

            int Number_By_User;

            do
            {
                
                Number_By_User = Convert.ToInt32(Console.ReadLine());
                if (Random_Number > Number_By_User)
                {
                    Console.WriteLine("Рандомное число больше введённого числа");
                }

                else if (Random_Number < Number_By_User)
                {
                    Console.WriteLine("Рандомное число меньше введённого числа");
                }
                else
                {
                    Console.WriteLine("Поздравляю! Вы угадали рандомное число ");
                  
                }
            }  while (Number_By_User != Random_Number);
        }



        static void Table_Of_Multiplication()
        {
            int[,] Table_Of_Multiplication = new int[10,10];
            for (int NumberVert = 1; NumberVert < 10; NumberVert++)
            {
                for (int NumberHoriz = 1; NumberHoriz < 10; NumberHoriz++)
                {

                    Console.Write(  NumberVert * NumberHoriz  + "\t" );
                   
                }
                Console.WriteLine();
            }
        }

        static void Prog_Divider()
        {
            Console.WriteLine("Введите число, для которого вы хотите найти делитель");
            int Number_By_User = Convert.ToInt32(Console.ReadLine());


            for (int Divider = 1; Divider < Number_By_User; Divider++)
            {

                if (Number_By_User % Divider == 0)
                {
                    Console.WriteLine("\t" + Divider + "\t");
                }

            }


        }
    }
}
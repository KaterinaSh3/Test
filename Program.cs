using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surename = "";
            int age = 0;
            int weight = 0;
            int responce = 0;             //@ дает вывести буквально как написано не разбивая по отдельным командам на каждую строку, не нужно писать консолрайтлайн каждый раз
            while (responce != -1)            //можно складывать строки "Enter 0 to enter name"+ Environment.NewLine+"Enter yoyr..."+Environment.NewLine+"..." - будет как с @                  

            {
                Console.WriteLine(@"Enter 0 to enter name                   
                                    Enter 1 to enter surename
                                    Enter 2 to enter age
                                    Enter 4 to enter weight
                                    Enter -2 to pint resume
                                    Enter -1 to exit");
                Console.WriteLine();
                responce = int.Parse(Console.ReadLine());
                switch (responce)            //switch:cases заменяет много if разделяет их на кейсы
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            name = Console.ReadLine();
                            break; //обязательно при switch
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter your surename");
                            surename = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter your weight");
                            weight = int.Parse(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            global::System.Console.WriteLine("enter correct unswer");
                            break;
                        }

                        {

                            Console.WriteLine("Enter your name");
                            Console.WriteLine("Enter your surename");
                            Console.WriteLine("Enter your age");
                        }
                }
                Console.WriteLine(name);
                Console.ReadKey();
            }
        }
    }
}

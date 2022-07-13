using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surename = "";
            int age = i;
            int responce = 0;             //@ дает вывести буквально как написано не разбивая по отдельным командам на каждую строку, не нужно писать консолрайтлайн каждый раз
            while (responce ! = -1)            //можно складывать строки "Enter 0 to enter name"+ Environment.NewLine+"Enter yoyr..."+Environment.NewLine+"..." - будет как с @                  
                Enter 1 to enter surename
            {
                Console.WriteLine(@"Enter 0 to enter name                   
                                    Enter 1 to enter surename
                                    Enter 2 to enter age
                                    Enter -2 to pint resume
                                    Enter -1 to exit");
                Console.WriteLine();
                responce = int.Parse(Console.ReadLine());
                switch(responce)            //switch:cases заменяет много if разделяет их на кейсы
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            name = Console.ReadLine();
                            break; //обязательно при switch
                        }
                    case 1:
                        {
                            Console.WrieLine("Enter your surename");
                            surename = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            global::System.Console.WriteLine("enter correct unswer");
                            break;
                        }
                if (responce==0)
                {
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                }
                if(responce == 1)
                {
                    Console.WrieLine("Enter your surename");
                    surename = Console.ReadLine();
                }
                if (responce==2)
                {
                    Console.WriteLine("Enter your age");
                    age = Console.ReadLine();
                }
                if (responce == -2)
                {

                    Console.WriteLine("Enter your name");
                    Console.WrieLine("Enter your surename");
                    Console.WrieLine("Enter your age");
                }
            }
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}

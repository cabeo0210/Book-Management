using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement;
namespace mainBookManagement
{
    class Program
    {
        public static int menu()
        {
            Console.WriteLine("\n******Book Management******");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Find book");
            Console.WriteLine("3. Show Book");
            Console.WriteLine("4. Remove Book");
            Console.WriteLine("5. Exit Book");
            int choice = 0;
            Console.Write("Input Command: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void Main(string[] args)
        {
            int choice;
            BookLib book = new BookLib();
            do
            {
                choice = menu();
                switch (choice)
                {
                    case 1:
                        {
                            String move;
                            do
                            {
                                book.GetBook();
                                Console.WriteLine("\nDo you want to continue? (Yes/No)");
                                move = Console.ReadLine();
                            } while (move.Equals("Yes"));
                            break;
                        }

                    case 2:
                        {
                            String move;
                            do
                            {
                                book.SearchBook();
                                Console.WriteLine("\nDo you want to continue? (Yes/No)");
                                move = Console.ReadLine();
                            } while (move.Equals("Yes"));
                            break;
                        }

                    case 3:
                        {
                            String move;
                            do
                            {
                                book.Show();
                                Console.WriteLine("\nDo you want to continue? (Yes/No)");
                                move = Console.ReadLine();
                            } while (move.Equals("Yes"));
                            break;
                        }

                    case 4:
                        {
                            String move;
                            do
                            {
                                book.RemoveBook();
                                Console.WriteLine("\nDo you want to continue? (Yes/No)");
                                move = Console.ReadLine();
                            } while (move.Equals("Yes"));
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Thank you !!!");
                            break;
                        }
                }
                if (choice > 5) {
                    Console.WriteLine("Please input command from 1 to 5 !!!");
                }
            } while (choice >= 1 && choice <= 4);
            
            
        }
    }
}

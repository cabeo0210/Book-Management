using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{

    public class BookLib
    {
        class Book
        {
            public int bookId;
            public string bookName;
            public int bookPrice;
            public int bookCount;
            public int x;
        }
        static List<Book> bookList = new List<Book>();
        static Book book = new Book();
        public void GetBook()
        {
            String price;
            Book book = new Book();
            Console.WriteLine("\nBook Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();           
            do
            {
                Console.Write("Book Price:");
                price = Console.ReadLine();
            } while (int.TryParse(price, out book.bookPrice) == false); 
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        public void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }


        public void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("| ++ Book id ++ |" + " ++ Book name ++ |" 
                            + " ++ Book price ++ |" + " ++ Book Count ++ |");
                        Console.WriteLine(("\t" + searchId.bookId + "   ")
                            + ("\t\t" + searchId.bookName + "  ") +
                            ("\t\t   " + searchId.bookPrice + " ") + ("\t\t\t" + searchId.bookCount + " "));
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public void Show()
        {
           

                foreach (var book in bookList)
                {
                    Console.WriteLine("| ++ Book id ++ |" + " ++ Book name ++ |" + " ++ Book price ++ |" + " ++ Book Count ++ |");
                    Console.WriteLine(("\t" + book.bookId + "   ") + ("\t\t" + book.bookName + "  ")
                        + ("\t\t   " + book.bookPrice + " ") + ("\t\t\t" + book.bookCount + " "));
                }

            
            
            

        }
    }
}


using BookClient.Commands;
using BookClient.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BookClient
{
    /// <summary>
    /// TODO: Add exception handlers to cach network exceptions
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BookClient bookClient = new BookClient("https://localhost:44335/book");
            Console.WriteLine("Hello to library client!");
            while (true)
            {
                Console.WriteLine($"{Environment.NewLine}Select 1 to get all books");
                Console.WriteLine("Select 2 to get book by id");
                Console.WriteLine("Select 3 to delete book by id");
                Console.WriteLine("Select 4 to update book");
                Console.WriteLine("Select 5 to add new book");

                int option;
                int.TryParse(Console.ReadLine(), out option);

                var commandsDictionary = GetCommandsDictionary(bookClient);
                try
                {
                    commandsDictionary[option].Execute();
                }
                catch(KeyNotFoundException)
                {
                    Console.WriteLine("Wrong command, please write correct one");
                }
            }
        }
        public static IDictionary<int, ICommand> GetCommandsDictionary(BookClient bk)
        {
            var commandsDictionary = new Dictionary<int, ICommand>();
            commandsDictionary.Add(1, new GetBooksCommand(bk));
            commandsDictionary.Add(2, new GetBookCommand(bk));
            commandsDictionary.Add(3, new DeleteBookCommand(bk));
            commandsDictionary.Add(4, new UpdateBookCommand(bk));
            commandsDictionary.Add(5, new InsertBookCommand(bk));

            return commandsDictionary;
        }
    }
}

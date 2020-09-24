using BookClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    public class InsertBookCommand : ICommand
    {
        BookClient bookClient;
        public InsertBookCommand(BookClient _bookClient)
        {
            bookClient = _bookClient;
        }

        public void Execute()
        {
            var bookToCreate = new Book();

            Console.WriteLine("Write a name");
            bookToCreate.Name = Console.ReadLine();

            Console.WriteLine("Write an author name");
            bookToCreate.Author = Console.ReadLine();

            Console.WriteLine("Write a price");
            bookToCreate.Price = float.Parse(Console.ReadLine());

            bookClient.InsertBook(bookToCreate);
        }
    }
}

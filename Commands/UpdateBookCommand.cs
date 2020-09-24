using BookClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    public class UpdateBookCommand: ICommand
    {
        BookClient bookClient;
        public UpdateBookCommand(BookClient _bookClient)
        {
            bookClient = _bookClient;
        }

        public void Execute()
        {

            Console.WriteLine("Ok, let's uppdate");
            Console.WriteLine("Write an Id of book that will be updated");
            var bookIdToUpdate = int.Parse(Console.ReadLine());
            var bookToUpdate = new Book();

            Console.WriteLine("Write a name");
            bookToUpdate.Name = Console.ReadLine();

            Console.WriteLine("Write an author name");
            bookToUpdate.Author = Console.ReadLine();

            Console.WriteLine("Write a price");
            bookToUpdate.Price = int.Parse(Console.ReadLine());

            bookClient.UpdateBook(bookIdToUpdate, bookToUpdate);
        }
    }
}

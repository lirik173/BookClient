using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    public class DeleteBookCommand : ICommand
    {
        BookClient bookClient;
        public DeleteBookCommand(BookClient _bookClient)
        {
            bookClient = _bookClient;
        }
        public void Execute()
        {
            Console.WriteLine("Please write an id of book to delete");
            int id = int.Parse(Console.ReadLine());
            bookClient.DeleteBook(id);
            Console.WriteLine("Book was deleted successfuly");
        }
    }
}

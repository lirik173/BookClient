using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    public class GetBooksCommand : ICommand
    {

        BookClient bookClient;
        public GetBooksCommand(BookClient _bookClient)
        {
            bookClient = _bookClient;
        }

        public void Execute()
        {
            var books = bookClient.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{Environment.NewLine} Number: {book.id} " +
                    $"|| Name: {book.Name} " +
                    $"|| Author: {book.Author} " +
                    $"|| Price: {book.Price}");
            }
        }
    }
}

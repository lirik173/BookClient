using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    public class GetBookCommand : ICommand
    {

        BookClient bookClient;
        public GetBookCommand(BookClient _bookClient)
        {
            bookClient = _bookClient;
        }

        public void Execute()
        {
            Console.WriteLine("Please write an id of book");
            var param = int.Parse(Console.ReadLine());
            if (param != null)
            {
                var book = bookClient.GetBook(param);
                Console.WriteLine($"{Environment.NewLine} Number: {book.id} " +
                   $"|| Name: {book.Name} " +
                   $"|| Author: {book.Author} " +
                   $"|| Price: {book.Price}");
            }
        }
    }
}

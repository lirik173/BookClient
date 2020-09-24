using BookClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace BookClient
{
    public class ClientHelper
    {
        public IEnumerable<Book> JsonToBooks(string BookListString)
        {
            var books = JsonConvert.DeserializeObject<List<Book>>($"{BookListString}");
            return books;
        }
        public Book JsonToBook(string BookListString)
        {
            var book = JsonConvert.DeserializeObject<Book>($"{BookListString}");
            return book;
        }
        public string BookToJson(Book book)
        {
            return JsonConvert.SerializeObject(book);
        }
    }
}

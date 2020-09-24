using BookClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace BookClient
{
    public class BookClient
    {
        private readonly HttpClient httpClient;
        private readonly ClientHelper clientHelper;
        private string url { get; set; }
        public BookClient(string _url)
        {
            httpClient = new HttpClient();
            url = _url;
            clientHelper = new ClientHelper();
        }
        public IEnumerable<Book> GetAllBooks()
        {
            var response = httpClient.GetStringAsync(url).Result;
            List<Book> result = clientHelper.JsonToBooks(response).ToList();
            return result;
        }
        public Book GetBook(int id)
        {
            var response = httpClient.GetStringAsync($"{url}/{id}").Result;
            Book result = clientHelper.JsonToBook(response);
            return result;
        }
        public async void InsertBook(Book book)
        {
            using (var requestContent = new StringContent(clientHelper.BookToJson(book), Encoding.UTF8, "application/json"))
            {
                using (var response = await httpClient.PostAsync($"{url}", requestContent))
                {
                    response.EnsureSuccessStatusCode();
                }
            }
        }
        public async void DeleteBook(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"{url}/{id}");
            response.EnsureSuccessStatusCode();
        }
        public async void UpdateBook(int id , Book book)
        {
            using (var requestContent = new StringContent(clientHelper.BookToJson(book), Encoding.UTF8, "application/json"))
            {
                using (var response = await httpClient.PutAsync($"{url}/{id}", requestContent))
                {
                    response.EnsureSuccessStatusCode();
                }
            }
        }
    }
}

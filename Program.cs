using JsonPlaceholderApi.DisplayMethods;
using JsonPlaceholderApi.Models;
using System.Net;

namespace JsonPlaceholderApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var apiClient = new ApiClient("https://jsonplaceholder.typicode.com");
            var postMethods = new PostMethods();
            var userMethods = new UserMethods();

            /*var posts = await apiClient.GetPostsAsync();
            postMethods.DisplayPosts(posts);

            var post = await apiClient.GetPostById(10);
            postMethods.DisplayPost(post);

            var users = await apiClient.GetUsersAsync();
            userMethods.DisplayUsers(users);*/


            Console.ReadLine();
        }

        
    }
}



using JsonPlaceholderApi.DisplayMethods;
using JsonPlaceholderApi.Models;
using System.Net;
using System.Xml.Linq;

namespace JsonPlaceholderApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var apiClient = new ApiClient("https://jsonplaceholder.typicode.com");
            var postMethods = new PostMethods();
            var userMethods = new UserMethods();
            var commentMethods = new CommentMethods();

            /*var posts = await apiClient.GetPostsAsync();
            postMethods.DisplayPosts(posts);*/

            /*var post = await apiClient.GetPostById(10);
            postMethods.DisplayPost(post);*/

            /*var users = await apiClient.GetUsersAsync();
            userMethods.DisplayUsers(users);*/

            /*var posts = await apiClient.GetPostsByUserAsync(2);
            postMethods.DisplayPost(post);*/

            /*var comments = await apiClient.GetCommentsByPostIdAsync(2);
            commentMethods.DisplayComments(comments);*/

            var posts = await apiClient.GetPostsByUserAsync(2);

            for (int i = 0; i < posts.Count; i++) 
            {
                var post = posts[i];

                var comments = await apiClient.GetCommentsByPostIdAsync(post.Id);

                for (int j = 0; j < comments.Count; j++)
                {
                    var comment = comments[j];

                    Console.WriteLine($"PostTitle: {post.Title}");
                    Console.WriteLine($"PostBody: {post.Body}\n");

                    Console.WriteLine($"PostId: {comment.PostId}");
                    Console.WriteLine($"Id: {comment.Id}");
                    Console.WriteLine($"Name: {comment.Name}");
                    Console.WriteLine($"Email: {comment.Email}");
                    Console.WriteLine($"Body: {comment.Body}\n");
                    Console.WriteLine("-----------------------------\n");
                }
            }

            Console.ReadLine();
        }        
    }
}



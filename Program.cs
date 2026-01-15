using JsonPlaceholderApi.DisplayMethods;
using JsonPlaceholderApi.DTO;
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

            /*var posts = await apiClient.GetPostsByUserAsync(2);

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
            }*/

            var createDto = new PostCreateDto
            {
                UserId = 1,
                Title = "Test",
                Body = "Test"
            };

            var newPost = await apiClient.CreatePostAsync(createDto);

            Console.WriteLine($"Id: {newPost.Id}");
            Console.WriteLine($"UserId: {newPost.UserId}");
            Console.WriteLine($"Title: {newPost.Title}");
            Console.WriteLine($"Body: {newPost.Body}");
            Console.WriteLine();

            var updateDto = new PostUpdateDto
            {
                UserId = 2,
                Title = "Testee",
                Body = "Testee"
            };

            var updatedPost = await apiClient.UpdatePutPostAsync(10, updateDto);

            Console.WriteLine($"Id: {updatedPost.Id}");
            Console.WriteLine($"UserId: {updatedPost.UserId}");
            Console.WriteLine($"Title: {updatedPost.Title}");
            Console.WriteLine($"Body: {updatedPost.Body}");
            Console.WriteLine();

            var post = await apiClient.GetPostById(10);

            string oldTitle = post.Title;
            Console.WriteLine($"Old UserId: {post.UserId}");
            Console.WriteLine($"Old title: {oldTitle}");
            Console.WriteLine($"Old Body: {post.Body}\n");

            var dto = new PostUpdateDto
            {         
                UserId = 2,
                Title = "Test123",
                Body = "jdçsifhaçidfh"
            };

            var patchPost = await apiClient.UpdatePatchPostAsync(10, dto);
            Console.WriteLine($"New UserId: {patchPost.UserId}");
            Console.WriteLine($"New title: {patchPost.Title}");
            Console.WriteLine($"New Body: {patchPost.Body}\n");

            await apiClient.DeletePostAsync(10);

            Console.ReadLine();
        }        
    }
}



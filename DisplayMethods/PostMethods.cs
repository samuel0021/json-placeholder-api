using JsonPlaceholderApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceholderApi.DisplayMethods
{
    public class PostMethods
    {
        public void DisplayPost(Post post)
        {
            Console.WriteLine($"UserID: {post.UserId}");
            Console.WriteLine($"ID: {post.Id}");
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Body: {post.Body}");
            Console.WriteLine();
        }

        public void DisplayPosts(List<Post> posts)
        {
            Console.WriteLine($"Total de posts: {posts.Count}");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"UserID: {posts[i].UserId}");
                Console.WriteLine($"ID: {posts[i].Id}");
                Console.WriteLine($"Title: {posts[i].Title}");
                Console.WriteLine($"Body: {posts[i].Body}");
                Console.WriteLine();
            }
        }
    }
}

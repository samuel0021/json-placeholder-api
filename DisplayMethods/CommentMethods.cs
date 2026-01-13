using JsonPlaceholderApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceholderApi.DisplayMethods
{
    public class CommentMethods
    {
        public void DisplayComments(List<Comment> comments)
        {
            foreach (var comment in comments)
            {
                Console.WriteLine($"PostId: {comment.PostId}");
                Console.WriteLine($"Id: {comment.Id}");
                Console.WriteLine($"Name: {comment.Name}");
                Console.WriteLine($"Email: {comment.Email}");
                Console.WriteLine($"Body: {comment.Body}");
            }
        }
    }
}

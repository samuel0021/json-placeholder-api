using JsonPlaceholderApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceholderApi
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(string baseUrl)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        #region Posts
        // GET /posts
        public async Task<List<Post>> GetPostsAsync()
        {
            var response = await _httpClient.GetAsync("/posts");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar posts: {response.StatusCode}");

            var posts = await response.Content.ReadFromJsonAsync<List<Post>>();

            return posts ?? new List<Post>();
        }

        // GET /posts/{id}
        public async Task<Post> GetPostById(int id)
        {
            var response = await _httpClient.GetAsync($"/posts/{id}");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar post: {response.StatusCode}");

            var posts = await response.Content.ReadFromJsonAsync<Post>();

            return posts ?? new Post();
        }

        // GET /posts?userId=
        public async Task<List<Post>> GetPostsByUserAsync(int userId)
        {
            var response = await _httpClient.GetAsync($"/posts?userId={userId}");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar posts: {response.StatusCode}");

            var posts = await response.Content.ReadFromJsonAsync<List<Post>>();
            return posts ?? new List<Post>();
        }

        // GET /posts/{id}/comments
        // GET /comments?postId={id}
        public async Task<List<Comment>> GetCommentsByPostIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"/posts/{id}/comments");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar comments: {response.StatusCode}");

            var comments = await response.Content.ReadFromJsonAsync<List<Comment>>();
            return comments ?? new List<Comment>();
        }

        #endregion

        #region Users
        // GET /users
        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync($"/users");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar usuários: {response.StatusCode}");

            var users = await response.Content.ReadFromJsonAsync<List<User>>();

            return users ?? new List<User>();
        }
        #endregion
    }
}

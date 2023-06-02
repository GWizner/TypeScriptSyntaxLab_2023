namespace API_intro.Models
{

    //https://jsonplaceholder.typicode.com/posts
    //we need NuGet Micrsoft.AspNet.WebApi.Client



    public class ApiConnection
    {
        private static HttpClient _httpClient = null;
        public static HttpClient Client
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();

                    _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

                    //if API key needed, add here:
                    //_httpClient.DefaultRequestHeaders.Add("some-api-key", "abcdefg1234");
                }
                return _httpClient;
            }
        }
        //asynchronous code using Async/await because web requests take a long time.


        public static async Task<List<Post>> GetPosts()
        {
            HttpResponseMessage response = await Client.GetAsync("posts");
            List<Post> posts = await response.Content.ReadAsAsync<List<Post>>();

            return posts;
        }
    }
}

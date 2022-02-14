using RestSharp;

namespace WeatherTestsAPI.Services
{
    public class BaseService
    {
        protected RestClient Client;

        protected RestRequest Request;

        public BaseService(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }

        public IRestResponse GetResponse(string requestPath, Method method)
        {
            Request = new RestRequest(requestPath, method);
            IRestResponse response = Client.Execute(Request);
            return response;
        }
    }
}
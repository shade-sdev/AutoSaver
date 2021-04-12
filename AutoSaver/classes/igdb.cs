using Newtonsoft.Json;
using RestSharp;



namespace AutoSaver
{
    public class igdb
    {

        public dynamic getIgdbResponse(string url, string clientid, string accesstoken, string body)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Client-ID", clientid);
            request.AddHeader("Authorization", accesstoken);
            request.AddHeader("Cookie", "__cfduid=dde30d03974d8beb32ce41e422f3551fc1616172455");
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            IRestResponse response = client.Execute(request);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return jsonResponse;
        }


        public string genAccessToken(string clientid, string secret)
        {
            var client = new RestClient("https://id.twitch.tv/oauth2/token?client_id=" + clientid + "&client_secret=" + secret + "&grant_type=client_credentials");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse response = client.Execute(request);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return jsonResponse["access_token"];
        }

        

    }
}

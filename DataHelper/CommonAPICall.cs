using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
namespace DataAccessLibrary
{
    public class CommonAPICall
    {
        public static string getAPICall(string URL,int timeout)
        {
            if (string.IsNullOrEmpty(URL))
                return string.Empty;

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();            
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            var response = client.GetAsync(URL).Result;
            return response.Content.ReadAsStringAsync().Result;            
        }
        public static string getAPICall(string URL, int timeout, string AuthKey)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            if (!string.IsNullOrEmpty(AuthKey))
                client.DefaultRequestHeaders.Add("Authorization", AuthKey);
            var response = client.GetAsync(URL).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
        public static string DialerAgentRTSCheck(string URL1, string URL2, int timeout)
        {            
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            var response = client.GetAsync(URL1).Result;
            response = client.GetAsync(URL2).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        public static void PostAPICall(string URL, int timeout,string Json,string AuthKey)
        {
            if (string.IsNullOrEmpty(URL))
                return;

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            StringContent content = new StringContent(Json, Encoding.UTF8, "application/json");
            if (!string.IsNullOrEmpty(AuthKey))
                client.DefaultRequestHeaders.Add("Authorization", AuthKey);
           client.PostAsync(URL, content);                            
        }
        public static void PostAPICall_Sync(string URL, int timeout, string Json, string AuthKey)
        {
            if (string.IsNullOrEmpty(URL))
                return;

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            StringContent content = new StringContent(Json, Encoding.UTF8, "application/json");
            if (!string.IsNullOrEmpty(AuthKey))
                client.DefaultRequestHeaders.Add("Authorization", AuthKey);
            var r = client.PostAsync(URL, content).Result;
        }

        public static void getAPICallAsync(string URL, int timeout)
        {
            if (!string.IsNullOrEmpty(URL))
            {
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                client.Timeout = TimeSpan.FromMilliseconds(timeout);
                client.GetAsync(URL);
            }
        }

        public static string PostAPICallWithResult(string URL, int timeout, string Json, string AuthKey)
        {
            string result = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(URL))
                    return string.Empty;
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                client.Timeout = TimeSpan.FromMilliseconds(timeout);
                StringContent content = new StringContent(Json, Encoding.UTF8, "application/json");
                if (!string.IsNullOrEmpty(AuthKey))
                    client.DefaultRequestHeaders.Add("Authorization", AuthKey);

                HttpResponseMessage response;
                response = client.PostAsync(URL, content).Result;
                using (Stream stream = response.Content.ReadAsStreamAsync().Result)
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    result = reader.ReadToEnd();
                    if (reader != null) reader.Close();
                }
            }
            catch
            {

            }
            return result;
        }
    }
}

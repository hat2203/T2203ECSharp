using Demo1.session5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment4
{
    public class CallApiWeather
    {
        public async Task<ApiWeather> FetchData()
        {

            string url = "https://dummyjson.com/products/1";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                ApiWeather a = JsonConvert.DeserializeObject<ApiWeather>(responseText);
                return a;

            }

            return null;
        }

    }
}

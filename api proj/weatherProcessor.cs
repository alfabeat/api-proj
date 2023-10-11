using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace api_proj
{
   public class weatherProcessor
    {
        public static async Task<weatherclass> LoadComic(string city= "London")
        {
            string url = "";

                url = $"https://api.weatherapi.com/v1/current.json?key=={city}&aqi=no";
            

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    wethercondion result = await response.Content.ReadAsAsync<wethercondion>();

                    return result.current;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
     
    }
    }


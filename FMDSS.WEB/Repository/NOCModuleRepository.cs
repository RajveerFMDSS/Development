using FMDSS.CustomModels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace FMDSS.WEB.Repository
{
    public class NOCModuleRepository
    {
        public string baseAddress = "http://localhost:3053";
        public async Task<StringResponse> SaveNOCByCitizen(NOCModel model)
        {
            StringResponse resp = new StringResponse();
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(baseAddress);
                    //httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.AccessToken);
                    //httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", token.AccessToken));
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    httpClient.DefaultRequestHeaders.Add("Referer", "http://localhost:1843");
                    StringContent content = new StringContent(JsonConvert.SerializeObject(model));
                    HttpResponseMessage response = await httpClient.PostAsync("api/NOCModule/SaveNOCByCitizen", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string str = response.Content.ReadAsStringAsync().Result;
                        resp = Newtonsoft.Json.JsonConvert.DeserializeObject<StringResponse>(str);

                    }
                    string message = response.Content.ReadAsStringAsync().Result;
                    System.Console.WriteLine("URL responese : " + message);
                }
            }
            catch (Exception ex)
            {

            }
            return resp;
        }
    }
}
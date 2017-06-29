using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FMDSS.WEB.TokenModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using FMDSS.CustomModels.Models;
namespace FMDSS.WEB.Repository
{
    public class Masters
    {
        public string baseAddress = "http://localhost:3053";
        public MasterPlaceModelResponse PlaceList()
        {
            MasterPlaceModelResponse model = new MasterPlaceModelResponse();

            string baseAddress = "http://localhost:3053";
            Token token = new Token();
            token.AccessToken = "5_B8oo-ptrbLysRbHxlIIXVqVndis5NJmbvZAv7ZtJORzmMo3eUf-2OIA4cw0Jg2pZgjr7yq-ZW_sde0PAQf2dQDD1GQUBYjmSX5lL3ObGGIsyWi_7pJu9tDGjYYttoyKiFPhqCAArhISvsIG8ljyg89mbjEphk3VC8Yv73_f7E3FJUmYQyNjwYNQrlGblLjQByEpPXV_2NMIXTsUKAuRq7zzX59aflIzYfb5_AMHQNuJTqlb9eUebJnLdU8dMLLPJhHMkdT9DADuu_Y5mL63nUUMUAEtSXih_37s6mkHbrcCfDQz34GVtErjDlyjwMY5cqFFZV_BviYgZMWYBGZjyA7vUp1ZFbWakt_IIHyGxCBZ2B4uwyVswlTeTcPecoHOT5DpHh3fD4IGceCpCvULqynHy0JR8JVy21-64GRvYk3bBxYOXI0i_tKGwBQwNklzC5l4b9YzjJuc8NV_RzhAKCaEDfJ7QkeFEOF1hPrGM8";
            if (string.IsNullOrEmpty(token.AccessToken))
            {
                token = new Token();
                using (var client = new System.Net.Http.HttpClient())
                {
                    var form = new Dictionary<string, string>
               {
                   {"grant_type", "password"},
                   {"username", "Rajveer"},
                   {"password", "user123456"},
               };
                    var tokenResponse = client.PostAsync(baseAddress + "/oauth/token", new FormUrlEncodedContent(form)).Result;
                    //var token = tokenResponse.Content.ReadAsStringAsync().Result;
                    token = tokenResponse.Content.ReadAsAsync<Token>(new[] { new JsonMediaTypeFormatter() }).Result;
                    if (string.IsNullOrEmpty(token.Error))
                    {
                        Console.WriteLine("Token issued is: {0}", token.AccessToken);
                        Console.WriteLine("Token Type: {0}", token.TokenType);
                    }
                    else
                    {
                        Console.WriteLine("Error : {0}", token.Error);
                    }
                }
            }
            // Next Request 
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseAddress);
                //httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.AccessToken);
                httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", token.AccessToken));
                httpClient.DefaultRequestHeaders.Add("Referer", "http://localhost:1843");
                HttpResponseMessage response = httpClient.GetAsync("api/Master/GetPlaceList").Result;
                if (response.IsSuccessStatusCode)
                {
                    string str = Newtonsoft.Json.JsonConvert.SerializeObject(response.Content.ReadAsStringAsync().Result);
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<MasterPlaceModelResponse>(str);
                }
                string message = response.Content.ReadAsStringAsync().Result;
                System.Console.WriteLine("URL responese : " + message);
            }

            return model;
        }

        #region Get GIS Information DropDown List

        public DropDownResponse FixedLandNocTypeList()
        {
            DropDownResponse model = new DropDownResponse();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseAddress);
                //httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.AccessToken);
                //httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", token.AccessToken));
                httpClient.DefaultRequestHeaders.Add("Referer", "http://localhost:1843");
                HttpResponseMessage response = httpClient.GetAsync("api/Master/FixedLandNocTypeList").Result;
                if (response.IsSuccessStatusCode)
                {
                    string str = response.Content.ReadAsStringAsync().Result;
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<DropDownResponse>(str);
                }
                string message = response.Content.ReadAsStringAsync().Result;
                System.Console.WriteLine("URL responese : " + message);
            }

            return model;
        }

        public DropDownResponse FixedLandPermissionTypesList(int? EmitraServiceID)
        {
            DropDownResponse model = new DropDownResponse();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseAddress);
                //httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.AccessToken);
                //httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", token.AccessToken));
                httpClient.DefaultRequestHeaders.Add("Referer", "http://localhost:1843");
                HttpResponseMessage response = httpClient.GetAsync("api/Master/FixedLandPermissionTypesList?EmitraServiceID"+ EmitraServiceID).Result;
                if (response.IsSuccessStatusCode)
                {
                    string str =response.Content.ReadAsStringAsync().Result;
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<DropDownResponse>(str);
                }
                string message = response.Content.ReadAsStringAsync().Result;
                System.Console.WriteLine("URL responese : " + message);
            }

            return model;
        }
        #endregion

        #region Get Plant List
        public DropDownResponse GetPlantList()
        {
            DropDownResponse model = new DropDownResponse();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseAddress);
                //httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.AccessToken);
                //httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", token.AccessToken));
                httpClient.DefaultRequestHeaders.Add("Referer", "http://localhost:1843");
                HttpResponseMessage response = httpClient.GetAsync("api/NOCModule/GetPlantList").Result;
                if (response.IsSuccessStatusCode)
                {
                    string str = response.Content.ReadAsStringAsync().Result;
                    model = Newtonsoft.Json.JsonConvert.DeserializeObject<DropDownResponse>(str);

                }
                string message = response.Content.ReadAsStringAsync().Result;
                System.Console.WriteLine("URL responese : " + message);
            }

            return model;
        }
        #endregion
    }
}
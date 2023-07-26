using Newtonsoft.Json;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Xml.Linq;

namespace HttpRequest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await callAPI();
            // Console.WriteLine(response);
        }

        public async static Task<List<CountryInfo>> callAPI()
        {
            try
            {
                String api = "https://restcountries.com/v3.1/all?fields=region,capital,area";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(api);
                    List<CountryInfo> countries = new List<CountryInfo>();

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        String stringResponse = await responseMessage.Content.ReadAsStringAsync();
                        //            JsonDocument document = JsonDocument.Parse(stringResponse);
                        //            JsonElement root = document.RootElement;
                        //            //JsonElement element = root[0];
                        //            if (root.ValueKind == JsonValueKind.String)
                        //            {
                        //                var enumarator = root.EnumerateArray();
                        //                foreach (JsonElement country in root.EnumerateArray())
                        //                {
                        //                    String capital = "";
                        //                    if (country.GetProperty("capital").GetArrayLength() > 0)
                        //                    {
                        //                        capital = country.GetProperty("capital")[0].GetString();
                        //                    }
                        //                    Double area = country.GetProperty("araea").GetDouble();
                        //                    String officialName = country.GetProperty("name").GetProperty("official").GetString();

                        //                }
                        //            }
                        List<CountryInfo> m = JsonConvert.DeserializeObject<List<CountryInfo>>(stringResponse);
                        Console.WriteLine(m.Count);
                    }
                    return countries;
                }
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Error Occurred");
            }
        }
    }
}

            
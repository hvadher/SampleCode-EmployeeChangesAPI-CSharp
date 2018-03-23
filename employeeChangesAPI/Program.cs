using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using employeeChangesAPI.Model;
using Newtonsoft.Json;

namespace employeeChangesAPI
{
    class Program
    {
        private static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {

            RunAsync().GetAwaiter().GetResult();

        }

        static async Task<List<EmployeeChangeModel>> GetEmployeeChangesAsync(string path)
        {
            List<EmployeeChangeModel> employeeChanges = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                string responseData = response.Content.ToString();
                employeeChanges = JsonConvert.DeserializeObject<List<EmployeeChangeModel>>(responseData);
            }
            return employeeChanges;
        }


        static async Task RunAsync()
        {
            //UPDATE to your api config file
            Model.APIConfigModel apiConfig = JsonConvert.DeserializeObject<APIConfigModel>(File.ReadAllText(@"secret/apiConfig.json"));


            // Update port # in the following line.
            client.BaseAddress = new Uri("https://" + apiConfig.APIUrlBase + "/personnel/v1/employee-changes");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("US-Customer-Api-Key", apiConfig.CustomerAPIKey);

            //Base 64 Encode Username and password for API Auth
            string usernamePass = apiConfig.UserName + ":" + apiConfig.Password;
            byte[] encodedByte = System.Text.ASCIIEncoding.ASCII.GetBytes(usernamePass);
            string base64Encoded = "Basic " + Convert.ToBase64String(encodedByte);

            client.DefaultRequestHeaders.Add("Authorization", base64Encoded);


            try
            {
                // Get the product
                var abc = await GetEmployeeChangesAsync(client.BaseAddress.ToString());

                Console.WriteLine(abc);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

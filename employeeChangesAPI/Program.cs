using System;
using System.IO;
using employeeChangesAPI.Model;
using Newtonsoft.Json;

namespace employeeChangesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            APIConfigModel sampleConfig = new APIConfigModel();
            sampleConfig.APIUrlBase = "{{APIURLHERE}}";
            sampleConfig.UserName = "{{USERNAMEHERE}}";
            sampleConfig.Password = "{{APIPASSWORDHERE}}";
            sampleConfig.CustomerAPIKey = "{{CUSTOMERAPIKEYHERE}}";
            sampleConfig.UserAPIKey = "{{USERAPIKEYHERE}}";


            File.WriteAllText(@"apiConfig.json", JsonConvert.SerializeObject(sampleConfig));

            */

            Model.APIConfigModel apiConfig = JsonConvert.DeserializeObject<APIConfigModel>(File.ReadAllText(@"testAccount.json"));


        }
    }
}

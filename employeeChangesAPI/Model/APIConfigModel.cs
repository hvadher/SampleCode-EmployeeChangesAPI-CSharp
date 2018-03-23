using System;
namespace employeeChangesAPI.Model
{
    public class APIConfigModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string APIUrlBase { get; set; }
        public string UserAPIKey { get; set; }
        public string CustomerAPIKey { get; set; }
    }
}

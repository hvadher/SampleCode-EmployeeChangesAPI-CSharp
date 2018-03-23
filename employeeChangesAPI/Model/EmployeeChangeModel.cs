using System;
namespace employeeChangesAPI.Model
{
    public class EmployeeChangeModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string preferredName { get; set; }
        public string emailAddress { get; set; }
        public string countryCode { get; set; }
        public string languageCode { get; set; }
        public string employeeNumber { get; set; }
        public string employeeId { get; set; }
        public string personId { get; set; }
        public string userIntegrationKey { get; set; }
        public string companyName { get; set; }
        public string companyId { get; set; }
        public string supervisorId { get; set; }
        public string salaryOrHourly { get; set; }
        public string fullTimeOrPartTime { get; set; }
        public bool isActive { get; set; }
        public string workLocationCode { get; set; }
        public string jobCode { get; set; }
        public string projectCode { get; set; }
        public string orgLevel1Code { get; set; }
        public string orgLevel2Code { get; set; }
        public string orgLevel3Code { get; set; }
        public string orgLevel4Code { get; set; }
        public string middleName { get; set; }
        public string workPhone { get; set; }
        public string homePhone { get; set; }
        public string employeeAddress1 { get; set; }
        public string employeeAddress2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public DateTime? terminationDate { get; set; }
        public DateTime? hireDate { get; set; }
        public string supervisorName { get; set; }
        public string suffix { get; set; }
        public string prefix { get; set; }
        public string alternateEmailAddress { get; set; }
        public string gender { get; set; }
    }
}

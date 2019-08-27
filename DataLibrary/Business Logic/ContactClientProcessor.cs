using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using DataLibrary.Data_Access;
using DataLibrary.Models;

namespace DataLibrary.Business_Logic
{
    public static class ContactClientProcessor
    {
       public static int CreateClient(string name, string emailAddress, string phoneNumber, string message)
        {
            ContactClientModel data = new ContactClientModel
            {
                Name = name,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                Message = message
            };
            string sql = @"insert into dbo.ClientContactInfo(Name, PhoneNumber, EmailAddress, Message)
            values(@Name, @PhoneNumber, @EmailAddress, @Message)";
            return SQLDataAccess.SaveData(sql, data);
        } 
        public static List<ContactClientModel>LoadClients()
        {
            string sql = @"select Id, Name, PhoneNumber, EmailAddress, Message
                from dbo.ClientContactInfo;";
            return SQLDataAccess.LoadData<ContactClientModel>(sql);

        }
    }
}

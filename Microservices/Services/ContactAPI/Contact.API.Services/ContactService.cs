using Contact.API.Infrasturcture;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO
            {
                Id = Id,
                Firstname = "Damla",
                Lastname = "Tokgöz"
            };
        }
    }
}

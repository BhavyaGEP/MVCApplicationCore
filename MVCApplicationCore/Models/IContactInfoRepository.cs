using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplicationCore.Models
{
    public interface IContactInfoRepository
    {
        public ContactInfo AddContactInfo(ContactInfo contact);
        IEnumerable<ContactInfo> GetAllContactInfos();
    }
}

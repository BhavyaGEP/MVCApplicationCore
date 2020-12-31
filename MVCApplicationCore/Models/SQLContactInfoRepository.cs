using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplicationCore.Models
{
    public class SQLContactInfoRepository : IContactInfoRepository
    {
        private readonly AppDbContext _context;
        public SQLContactInfoRepository(AppDbContext context)
        {
            _context = context;
        }
        public ContactInfo AddContactInfo(ContactInfo contact)
        {
            _context.ContactInfos.Add(contact);
            _context.SaveChanges();
            return contact;
        }
        public IEnumerable<ContactInfo> GetAllContactInfos()
        {
            return _context.ContactInfos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApplicationCore.Models;
using MVCApplicationCore.ViewModels;

namespace MVCApplicationCore.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoRepository _context;

        public ContactInfoController(IContactInfoRepository context)
        {
            _context = context;
        }

        // GET: ContactInfo
        public IActionResult Index()
        {
            return View(_context.GetAllContactInfos().ToList());
        }

        // GET: ContactInfo/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInfo =  _context.GetAllContactInfos()
                .FirstOrDefault(m => m.Id == id);
            if (contactInfo == null)
            {
                return NotFound();
            }

            return View(contactInfo);
        }

        // GET: ContactInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactInfoViewModel contactInfo)
        {
            if (ModelState.IsValid)
            {
                var contact = new ContactInfo()
                {
                    FirstName = contactInfo.FirstName,
                    LastName = contactInfo.LastName,
                    EmailAddress = contactInfo.EmailAddress,
                    PhoneNumber = contactInfo.PhoneNumber,
                    Message = contactInfo.EmailAddress,
                    ContactPurpose = contactInfo.ContactPurpose
                };
                _context.AddContactInfo(contact);
                return RedirectToAction(nameof(Index));
            }
            return View(contactInfo);
        }       

        private bool ContactInfoExists(int id)
        {
            return _context.GetAllContactInfos().Any(e => e.Id == id);
        }
    }
}

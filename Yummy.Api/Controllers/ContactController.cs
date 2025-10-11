using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Api.Context;
using Yummy.Api.DTO.ContactDTO;
using Yummy.Api.Entity;

namespace Yummy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDTO createContactDTO)
        {
            Contact contact = new Contact();
            contact.Email = createContactDTO.Email;
            contact.Address = createContactDTO.Address;
            contact.Phone = createContactDTO.Phone;
            contact.MapLocation = createContactDTO.MapLocation;
            contact.OpenHours = createContactDTO.OpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme İşlemi Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarılı");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
        {
            Contact contact = new Contact();
            contact.Email = updateContactDTO.Email;
            contact.Address = updateContactDTO.Address;
            contact.Phone = updateContactDTO.Phone;
            contact.ContactID = updateContactDTO.ContactID;
            contact.OpenHours = updateContactDTO.OpenHours;
            contact.MapLocation = updateContactDTO.MapLocation;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme tamamlandı");
        }
    }
}

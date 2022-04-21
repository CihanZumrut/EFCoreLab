using EFCoreLab.Data.Context;
using EFCoreLab.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLab.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StudentController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {


            var allStudents = await applicationDbContext.Students.ToListAsync();
            var lastNameFiltered = await applicationDbContext.Students
                .Where(i => i.LastName == "Kaya") //Linq and Lambda Express
                .Where(i => i.FirstName != "Cihan")
                .OrderBy(i => i.FirstName)
                .OrderByDescending(i => i.Number)    
                .ToListAsync();
            
            var student = await applicationDbContext.Students.ToListAsync();
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            Student st = new Student()
            {
                FirstName = "Cihan",
                LastName = "Zümrüt",
                Number = 1,
                Address = new StudentAddress()
                {
                    City = "İstanbul",
                    Country = "Türkiye",
                    District = "Bakırköy",
                    FullAddress = "X sokak, No: y"
                }
            };

            await applicationDbContext.Students.AddAsync(st);
            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await applicationDbContext.StudentAddresses.FindAsync(id);
            applicationDbContext.StudentAddresses.Remove(student);

            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            var student = await applicationDbContext.Students.FirstOrDefaultAsync();

            student.FirstName = "CİHAN";
            student.LastName = "ZÜMRÜT";

            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}

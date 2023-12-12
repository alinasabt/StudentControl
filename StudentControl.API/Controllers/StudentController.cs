using Microsoft.AspNetCore.Mvc;
using StudentControl.Infrastructure;
using StudentControl.Domain;
using StudentControl.Infrastructure.Repository;
using StudentControl.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Context context;
        private readonly StudentRepository studentRepository;

        public StudentController(Context context)
        {
            this.context = context;
            studentRepository = new StudentRepository(context);
        }
        //AutoMapper
        //DTO C#
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await studentRepository.GetAllAsync();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(Guid id)
        {
            try
            {
                var student = await studentRepository.GetByIdAsync(id);
                if (student == null)
                {
                    return NotFound();
                }

                return Ok(student);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {
            if (context.Students.Any(stud => stud.Id == student.Id)) return BadRequest();
            await studentRepository.AddAsync(student);
            return CreatedAtAction(nameof(Post), new { id = student.Id }, student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> Put(Guid id, Student student)
        {

            if (id != student.Id && !context.Students.Any(stud => stud.Id == student.Id)) return BadRequest();
            await studentRepository.UpdateAsync(student);
            return Ok(await studentRepository.GetByIdAsync(id));
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

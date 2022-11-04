using Microsoft.AspNetCore.Mvc;
using WebApiUniversidad.Contexto;
using WebApiUniversidad.Entities;

namespace WebApiUniversidad.Controllers.V1
{
    [ApiController]
    [Route("V1/estudiantes")]
    public class EstudiantesController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public EstudiantesController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        //async / await
        public async Task<ActionResult<List<Estudiante>>> Get()
        {
            return dbContext.Estudiante.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Estudiante estudiante)
        {
            dbContext.Estudiante.Add(estudiante);

            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var estudiante = await dbContext.Estudiante.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }

            dbContext.Remove(estudiante);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

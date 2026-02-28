using JamTechSalary.API.Data;
using JamTechSalary.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyResponsesController(JamTechSalaryDbContext context) : ControllerBase
    {
        private readonly JamTechSalaryDbContext _context = context;

        // GET: api/SurveyResponses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveyResponse>>> GetSurveyResponse()
        {
            return await _context.SurveyResponse.ToListAsync();
        }

        // GET: api/SurveyResponses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SurveyResponse>> GetSurveyResponse(int id)
        {
            var surveyResponse = await _context.SurveyResponse.FindAsync(id);

            if (surveyResponse == null)
            {
                return NotFound();
            }

            return surveyResponse;
        }

        // PUT: api/SurveyResponses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyResponse(int id, SurveyResponse surveyResponse)
        {
            if (id != surveyResponse.Id)
            {
                return BadRequest();
            }

            _context.Entry(surveyResponse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyResponseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SurveyResponses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SurveyResponse>> PostSurveyResponse(SurveyResponse surveyResponse)
        {
            _context.SurveyResponse.Add(surveyResponse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurveyResponse", new { id = surveyResponse.Id }, surveyResponse);
        }

        // DELETE: api/SurveyResponses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurveyResponse(int id)
        {
            var surveyResponse = await _context.SurveyResponse.FindAsync(id);
            if (surveyResponse == null)
            {
                return NotFound();
            }

            _context.SurveyResponse.Remove(surveyResponse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SurveyResponseExists(int id)
        {
            return _context.SurveyResponse.Any(e => e.Id == id);
        }
    }
}

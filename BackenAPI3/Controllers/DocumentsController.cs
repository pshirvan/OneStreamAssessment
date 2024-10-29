using BackendAPI3.Data;
using BackendAPI3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackenAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DocumentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocumentsAsync()
        {
            var documents = await _context.Documents.ToListAsync();
            return Ok(documents);
        }

        [HttpPost]
        public async Task<IActionResult> AddDocument([FromBody] AppDocument document)
        {
            _context.Documents.Add(document);
            await _context.SaveChangesAsync();
            return Ok(document);
        }
    }
}

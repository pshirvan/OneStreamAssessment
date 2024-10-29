using FrontendAPI.Models;
using FrontendAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IBackendService _backendService;

        public DocumentsController(IBackendService backendService)
        {
            _backendService = backendService;
        }

        [HttpGet("backend2/all")]
        public async Task<IActionResult> GetAllFromBackendAPI2()
        {
            var documents = await _backendService.GetDocumentsFromBackendAPI2();
            return Ok(documents);
        }

        [HttpGet("backend3/all")]
        public async Task<IActionResult> GetAllFromBackendAPI3()
        {
            var documents = await _backendService.GetDocumentsFromBackendAPI3();
            return Ok(documents);
        }

        [HttpPost("backend2")]
        public async Task<IActionResult> AddDocumentToBackendAPI2([FromBody] AppDocument document)
        {
            var addedDocument = await _backendService.AddDocumentToBackendAPI2(document);
            return Ok(addedDocument);
        }

        [HttpPost("backend3")]
        public async Task<IActionResult> AddDocumentToBackendAPI3([FromBody] AppDocument document)
        {
            var addedDocument = await _backendService.AddDocumentToBackendAPI3(document);
            return Ok(addedDocument);
        }
    }

}

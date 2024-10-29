using FrontendAPI.Models;

namespace FrontendAPI.Services
{
    public interface IBackendService
    {
        Task<List<AppDocument>> GetDocumentsFromBackendAPI2();
        Task<List<AppDocument>> GetDocumentsFromBackendAPI3();
        Task<AppDocument> AddDocumentToBackendAPI2(AppDocument document);
        Task<AppDocument> AddDocumentToBackendAPI3(AppDocument document);
    }
}

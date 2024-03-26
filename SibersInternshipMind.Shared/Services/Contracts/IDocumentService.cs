using SibersInternshipMind.Shared.Entities;
using System.Collections.Generic;

namespace SibersInternshipMind.Shared.Services.Contracts
{
    public interface IDocumentService
    {
        List<Document> GetAllDocuments();
        Document GetDocumentById(int id);
        bool AddDocument(DocumentDTO documentDto);
        bool UpdateDocument(int documentId, DocumentDTO documentDto);
        bool DeleteDocument(int id);
        List<Document> GetAllDocumentsOfOneProject(int projectId);
    }
}

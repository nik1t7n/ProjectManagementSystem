using SibersInternshipMind.Shared.Data;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SibersInternshipMind.Shared.Services.Implementations
{
    public class DocumentService : IDocumentService
    {
        private readonly DataContext _context;

        public DocumentService(DataContext context)
        {
            _context = context;
        }

        public bool AddDocument(DocumentDTO documentDto)
        {
            if (documentDto == null)
                throw new ArgumentNullException(nameof(documentDto));

            var document = new Document
            {
                Name = documentDto.Name,
                FilePath = documentDto.FilePath,
                FileType = documentDto.FileType,
                ProjectId = documentDto.ProjectId
            };

            _context.Documents.Add(document);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteDocument(int id)
        {
            var documentToDelete = _context.Documents.Find(id);
            if (documentToDelete != null)
            {
                _context.Documents.Remove(documentToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Document> GetAllDocuments()
        {
            return _context.Documents.ToList();
        }

        public List<Document> GetAllDocumentsOfOneProject(int projectId)
        {
            // Получаем все документы с заданным projectId
            var documentsOfProject = _context.Documents.Where(d => d.ProjectId == projectId).ToList();
            return documentsOfProject;
        }

        public Document GetDocumentById(int id)
        {
            var document = _context.Documents.Find(id);
            if (document == null)
            {
                throw new ArgumentException($"Document with id {id} not found.");
            }
            return document;
        }

        public bool UpdateDocument(int documentId, DocumentDTO documentDto)
        {
            if (documentDto == null)
                throw new ArgumentNullException(nameof(documentDto));

            var existingDocument = _context.Documents.Find(documentId);
            if (existingDocument == null)
            {
                throw new ArgumentException($"Document with id {documentId} not found.");
            }

            existingDocument.Name = documentDto.Name;
            existingDocument.FilePath = documentDto.FilePath;
            existingDocument.FileType = documentDto.FileType;
            existingDocument.ProjectId = documentDto.ProjectId;

            _context.Documents.Update(existingDocument);
            _context.SaveChanges();

            return true;
        }
    }
}

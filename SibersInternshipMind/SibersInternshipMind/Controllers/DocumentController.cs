using Microsoft.AspNetCore.Mvc;
using SibersInternshipMind.Shared.DTOs;
using SibersInternshipMind.Shared.Entities;
using SibersInternshipMind.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace SibersInternshipMind.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<SibersInternshipMind.Shared.Entities.Document>> GetAllDocuments()
        {
            return _documentService.GetAllDocuments();
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<SibersInternshipMind.Shared.Entities.Document> GetEmployeeById(int id)
        {
            try
            {
                var document = _documentService.GetDocumentById(id);
                return document;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("Add")]
        public IActionResult AddDocument(DocumentDTO documentDto)
        {
            if (_documentService.AddDocument(documentDto))
            {
                return Ok("Employee added successfully");
            }
            else
            {
                return BadRequest("Failed to add employee");
            }
        }

        [HttpPut("Update/{documentId}")]
        public IActionResult UpdateDocument(int documentId, DocumentDTO documentDto)
        {
            if (_documentService.UpdateDocument(documentId, documentDto))
            {
                return Ok("Document updated successfully");
            }
            else
            {
                return BadRequest("Failed to update Document");
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteDocument(int id)
        {
            if (_documentService.DeleteDocument(id))
            {
                return Ok("Document deleted successfully");
            }
            else
            {
                return NotFound("Document not found");
            }
        }

        [HttpGet("GetAllDocumentsOfOneProject/{projectId}")]
        public IActionResult GetAllDocumentsOfOneProject(int projectId)
        {
            var documents = _documentService.GetAllDocumentsOfOneProject(projectId);

            if (documents == null)
            {
                return NotFound();
            }

            return Ok(documents);
        }
    }
}

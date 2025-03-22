using BookStoreManagement_Db_Context.DataContext;
using BookStoreManagement_Application.Interfaces;
using BookStoreManagement_Application.Dto;
using BookStoreManagement_Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreManagement_Application.Services
{
    public class RecordService : IRecordService
    {
        private readonly ApplicationDbContext _context;

        public RecordService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RecordResponseDto> GetAllEntries()
        {
            return _context.Records
                .Select(r => new RecordResponseDto
                {
                    Id = r.Id,
                    UserName = r.User.Name,
                    BookName = r.Book.Name,
                    IssueDate = r.IssueDate,
                    DueDate = r.DueDate,
                    Status = r.Status
                })
                .ToList();
        }

        public void AddNewEntry(RecordCommand record)
        {
            if (record == null)
            {
                throw new ArgumentException("Invalid data.");
            }

            var newRecord = new Record
            {
                UserId = record.UserId,
                BookId = record.BookId,
                IssueDate = record.IssueDate,
                DueDate = record.DueDate,
                Status = record.Status
            };

            _context.Records.Add(newRecord);
            _context.SaveChanges();
        }

        public void UpdateEntryById(int id, RecordCommand updatedRecord)
        {
            var existingRecord = _context.Records.FirstOrDefault(r => r.Id == id);

            if (existingRecord == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }

            existingRecord.UserId = updatedRecord.UserId;
            existingRecord.BookId = updatedRecord.BookId;
            existingRecord.IssueDate = updatedRecord.IssueDate;
            existingRecord.DueDate = updatedRecord.DueDate;
            existingRecord.Status = updatedRecord.Status;

            _context.SaveChanges();
        }

        public List<RecordResponseDto> GetEntriesByUserId(int userId)
        {
            return _context.Records
                .Where(r => r.UserId == userId)
                .Select(r => new RecordResponseDto
                {
                    Id = r.Id,
                    UserName = r.User.Name,
                    BookName = r.Book.Name,
                    IssueDate = r.IssueDate,
                    DueDate = r.DueDate,
                    Status = r.Status
                })
                .ToList();
        }
    }
}

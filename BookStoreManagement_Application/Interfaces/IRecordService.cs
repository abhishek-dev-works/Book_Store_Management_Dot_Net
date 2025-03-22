using BookStoreManagement_Application.Commands;
using BookStoreManagement_Application.Dto;

namespace BookStoreManagement_Application.Interfaces
{
    public interface IRecordService
    {
        List<RecordResponseDto> GetAllEntries();
        void AddNewEntry(RecordCommand record);
        void UpdateEntryById(int id, RecordCommand record);
        List<RecordResponseDto> GetEntriesByUserId(int userId);
    }

}

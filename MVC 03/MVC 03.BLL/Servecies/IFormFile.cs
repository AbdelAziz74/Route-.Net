
namespace MVC_03.BLL.Servecies
{
    public interface IFormFile
    {
        string? FileName { get; }
        int Length { get; }

        Task CopyToAsync(Stream fileStream);
    }
}
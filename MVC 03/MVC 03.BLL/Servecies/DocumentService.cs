using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.BLL.Servecies
{
    public class DocumentService : IDocumentService
    {
        private List<string> _allowedExtensions = [".png", ".jpeg", ".jpg"];

        public async Task<string?> UploadAsync(IFormFile file, string folderName)
        {
            var extemsion = Path.GetExtension(file.FileName);
            if (!_allowedExtensions.Contains(extemsion))
                return null;
            if (file.Length > MAX_SIZE)
                return null;
            var fileName = $"{Guid.NewGuid()}{extemsion}";
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", folderName);
            var filePath = Path.Combine(folderPath, fileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);

            await file.CopyToAsync(fileStream);

            return fileName;
        }
    }
}

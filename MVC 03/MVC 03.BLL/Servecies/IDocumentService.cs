using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.BLL.Servecies
{
    public class IDocumentService
    {
        Task<string?> UploadeAsync(IFormFile file, string folderName);
        Task<bool> DeleteAsync(string filePath);
    }
}

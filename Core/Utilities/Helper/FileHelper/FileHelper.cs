using Core.Utilities.Helper.GuidHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper.FileHelper
{
    public class FileHelper : IFileHelper
    {
        public string Add(IFormFile file)
        {
            string fileExtension = Path.GetExtension(file.FileName);
            string uniqFileName = GuidHelper_.Create() + fileExtension;
            var imagePath = FilePath.Full(uniqFileName);
            using FileStream fileStream = new(imagePath, FileMode.Create);
            file.CopyTo(fileStream); ;
            fileStream.Flush();
            return uniqFileName;
        }

        public void Delete(string path)
        {
            if(Path.Exists(FilePath.Full(path)))
            {
                File.Delete(FilePath.Full(path));
            }
            else
            {
                throw new DirectoryNotFoundException("Dosya bulunamadı");
            }
        }

        public void Update(IFormFile file, string imagePath)
        {
            var fullpath = FilePath.Full(imagePath);
            if (Path.Exists(fullpath))
            {
                using FileStream fileStream= new(fullpath, FileMode.Create);
                file.CopyTo(fileStream);
                fileStream.Flush();

            }
            else {

                throw new DirectoryNotFoundException("Dosya bulunamadı");
            }


        }
    }
}

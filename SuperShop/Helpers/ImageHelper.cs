using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile, string name, string folder)
        {

            var guid = Guid.NewGuid().ToString();
            var file = $"{guid}_{name}.jpg".Replace(" ", "_");

            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\images\\{folder}", file);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return $"~/images/{folder}/{file}";
        }

        public void DeleteImage(string imageUrl)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", imageUrl.Substring(2));

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            };
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IBlobHelper
    {
        Task<Guid> UploadBloblAsync(IFormFile file, string containerName);

        Task<Guid> UploadBloblAsync(byte[] file, string containerName);

        Task<Guid> UploadBloblAsync(string image, string containerName);
    }
}

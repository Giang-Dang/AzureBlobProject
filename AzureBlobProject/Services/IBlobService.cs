using AzureBlobProject.Models;

namespace AzureBlobProject.Services
{
    public interface IBlobService
    {
        Task<List<string>> GetAllBlobNames(string containerName);
        Task<List<Blob>> GetAllBlobsWithUriAsync(string containerName);
        string GetBlob(string name, string containerName);
        Task<bool> UploadBlob(string name, IFormFile file, string containerName, Blob blob);
        Task<bool> DeleteBlob(string name, string containerName);
    }
}

using System;
using System.Threading.Tasks;
using ObjectDetection.Models;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace ObjectDetection.Services
{
    public interface IDataService
    {
        Task<ResponseEntity> UploadImageAsync(MediaFile file);
        Task<ResponseEntity> GetImageById(string id);
        Task<ResponseEntity> GetImages();
    }
}

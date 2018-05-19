using System;
using ObjectDetection.Models;
using Xamarin.Forms;

namespace ObjectDetection.Services
{
    public interface IDataService
    {
        ResponseEntity UploadImage(Image image);
        ResponseEntity GetImageById(string id);
        ResponseEntity GetImages();
    }
}

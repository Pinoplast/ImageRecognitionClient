using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using ObjectDetection.Models;
using Xamarin.Forms;

namespace ObjectDetection.Services
{
    public class DataService : IDataService
    {
        HttpClient client;

        public DataService()
        {
            client = new HttpClient();
            //client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");
        }

        public ResponseEntity UploadImage(Image image)
        {
            throw new Exception();
        }

        public ResponseEntity GetImageById(string id)
        {
            throw new Exception();       
        }

        public ResponseEntity GetImages()
        {
            throw new Exception();        
        }
    }
}
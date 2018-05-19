using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using ObjectDetection.Models;
using Xamarin.Forms;
using System.IO;
using Plugin.Media.Abstractions;
using System.Threading;
using System.Diagnostics;

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

        public async Task<ResponseEntity> UploadImageAsync(MediaFile file) 
        {
            byte[] byteArray;
            using (var memoryStream = new MemoryStream())
            {
                file.GetStream().CopyTo(memoryStream);
                file.Dispose();
                byteArray = memoryStream.ToArray();

            }
            ByteArrayContent byteArrayContent = new ByteArrayContent(byteArray);
            Uri webService = new Uri("");
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, webService);
            MultipartFormDataContent dataContent = new MultipartFormDataContent();
            byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
            dataContent.Add(byteArrayContent, "fileName");
            try
            {
                HttpResponseMessage httpRequest = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                var responseContent = await httpRequest.Content.ReadAsStringAsync();
                //ProgressBarWidth += Percentage;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            throw new Exception();
        }

        public async Task<ResponseEntity> GetImageById(string id)
        {
            throw new Exception();       
        }

        public async Task<ResponseEntity> GetImages()
        {
            throw new Exception();        
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ObjectDetection.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            List<string> urls = new List<string>(){
                "https://designcode.io/iphone-x-wallpapers",
                "http://www.ilikewallpaper.net/iphone-x/wallpapers/Views",
                "http://www.idownloadblog.com/2017/11/26/original-apple-wallpapers-optimized-for-iphone-x/",
                "http://www.iphonehacks.com/2017/12/download-new-iphone-x-wallpapers-ios-11-2.html",
                "https://unsplash.com/collections/1466477/iphone-x-wallpapers"
            };
            List<Bitmap> images = new List<Bitmap>();
            foreach(var url in urls)
            {
                var imageBitmap = GetImageBitmapFromUrl(url);
                images.Add(imageBitmap);
            }
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }
    }
}
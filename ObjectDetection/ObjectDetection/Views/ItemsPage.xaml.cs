using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ObjectDetection.Models;
using ObjectDetection.Views;
using ObjectDetection.ViewModels;
using Plugin.Media.Abstractions;
using Plugin.Media;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.IO;

namespace ObjectDetection.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();

            Image = new Image();

            CameraButton.Clicked += CameraButton_Clicked;
            ChooseButton.Clicked += ChooseButton_Clicked;
        }

        private async void ChooseButton_Clicked(object sender, EventArgs e)
        {
            try{
                if (CrossMedia.Current.IsPickPhotoSupported)
                {
                    MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
                    await DisplayAlert("Show error", photo.Path, "OK");
                    Image.Source = ImageSource.FromFile(photo.Path);
                }
            }
            catch(Exception ex) 
            {
                await DisplayAlert("Error", ex.ToString(), "OK");
            }
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            try{
                await CrossMedia.Current.Initialize();
                MediaFile photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Receipts",
                    Name = DateTime.Now.ToLongTimeString()
                });
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.ToString(), "OK");
            }
        }
        //}

        public Image Image { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
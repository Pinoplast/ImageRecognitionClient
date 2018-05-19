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

namespace ObjectDetection.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }

       /* async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            
        }*/

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
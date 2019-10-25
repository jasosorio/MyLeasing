using MyLeasing.Common.Helpers;
using MyLeasing.Common.Models;
using MyLeasing.Prism.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyLeasing.Prism.Views
{
    public partial class PropertyPage : ContentPage
    {
        public PropertyPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            rotator.ItemsSource = GetDataSource();

            var imageTemplate = new DataTemplate(() =>
            {
                var image = new Image();
                image.SetBinding(Image.SourceProperty, "Image");
                return image;
            }); 

            rotator.ItemTemplate = imageTemplate;
        }

        private IEnumerable<CustomData> GetDataSource()
        {
            List<CustomData> list = new List<CustomData>();
            var propertyImages = JsonConvert.DeserializeObject<List<PropertyImageResponse>>(Settings.PropertyImages);
            foreach (var itepropertyImage in propertyImages)
            {
                list.Add(new CustomData(itepropertyImage.ImageUrl));
            }

            return list;
        }
    }
}

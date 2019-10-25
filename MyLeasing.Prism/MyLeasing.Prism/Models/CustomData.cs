using Xamarin.Forms;

namespace MyLeasing.Prism.Models
{
    public class CustomData : ContentPage
    {
        public CustomData()
        {
        }

        public CustomData(string image)
        {
            Image = image;
        }

        public string Image { get; set; }
    }
}

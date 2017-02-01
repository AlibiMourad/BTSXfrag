using System;
using Windows.System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace BTSxfrag.UWP
{
    public sealed partial class XamarinMapOverlayTt : UserControl
    {
       

        CustomPin customPin;

        public XamarinMapOverlayTt(CustomPin pin)
        {
            this.InitializeComponent();
            customPin = pin;
            SetupData();
        }

        void SetupData()
        {
            Label.Text = customPin.Pin.Label;
            Address.Text = customPin.Pin.Address;
        }

        private async void OnInfoButtonTapped(object sender, TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(customPin.Url));
        }
    }
}

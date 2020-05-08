using Plugin.DeviceInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDeviceInfo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var deviceIdResult = new Label();
            var deviceId = CrossDeviceInfo.Current.Id;


            deviceIdResult.Text = deviceId;

            titleDeviceId.Text = "My device Id: " + "\n" + deviceIdResult.Text + "\n";
            titleDeviceId.Text += "Name" + "\n" + CrossDeviceInfo.Current.DeviceName + "\n";
            titleDeviceId.Text += "Model" + "\n" + CrossDeviceInfo.Current.Manufacturer + "." + CrossDeviceInfo.Current.Model + "\n";
            titleDeviceId.Text += "Version" + "\n" + CrossDeviceInfo.Current.Version + "." + CrossDeviceInfo.Current.VersionNumber + "\n";
            titleDeviceId.Text += "Platform" + "\n" + CrossDeviceInfo.Current.Platform;



        }
    }
}

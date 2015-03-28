using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        public static HttpClient client = new HttpClient();
        public static Uri url;
        public static MainUserObject finalObj;
        private async void goclick(object sender, RoutedEventArgs e)
        {
            url = new Uri("http://codeforces.com/api/user.info?handles=mishraiiit");
            var temp = await client.GetStringAsync(url);
            finalObj = JsonConvert.DeserializeObject<MainUserObject>(temp);
            disptextu.Text = finalObj.result[0].handle.ToString();
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
//using Microsoft.AspNetCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;


namespace iWebAssembly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WebAssemblyLibrary.Helper.SetLastVersionIE();

            Task.Run(() => 
            {
                WebAssemblyLibrary.WebAssembly.CreateWebHostBuilder().Build().Run();
            });

            var currentDirectory = Directory.GetCurrentDirectory();
            var path = System.IO.Path.Combine(currentDirectory, "wwwroot", "index.html");
            this.webBrowser.Navigate(path);
        }
    }
}

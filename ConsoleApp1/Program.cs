using HtmlToImage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // From HTML string
            var converter = new HtmlConverter();
            var html = "<div><strong>Hello</strong> World!</div>";
            //var htmlBytes = converter.FromHtmlString(html);

            // From URL
            var urlBytes = converter.FromUrl("https://m.graz.me/", 800, format: ImageFormat.Png, quality: 90);
            File.WriteAllBytes("D:\\imageerter.png", urlBytes);
        }
    }
}

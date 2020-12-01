using System;
using Xamarin.Forms;

[assembly: ExportFont("font_samantha.ttf", Alias = "samantha")]
namespace fonts_collection_1
{
    public static class ExportFonts
    {
        public static string Regular => "samantha";
    }
}

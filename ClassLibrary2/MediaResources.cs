// ReSharper disable InconsistentNaming

using System;
using System.Windows.Media.Imaging;

namespace ClassLibrary2
{
    public static class MediaResourceUris
    {
        public const string Autofocus_16 = "pack://application:,,,/ClassLibrary2;component/Resources/Autofocus_16.png";
    }

    public static class MediaResourceImages
    {
        public static readonly BitmapImage Autofocus_16 = new BitmapImage(new Uri(MediaResourceUris.Autofocus_16));
    }
}
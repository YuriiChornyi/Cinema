using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Cinema
{
    public static class Imagerecover
    {
        public static Bitmap byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Bitmap returnImage = Bitmap.FromStream(ms) as Bitmap;
            return returnImage;
        }
    }
}
using System;
using Plugin.Media.Abstractions;

namespace ObjectDetection.Models
{
    public class ImageObject
    {
        public string Id { get; set; }
        public MediaFile Image { get; set; }
    }
}
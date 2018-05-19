using System;
namespace ObjectDetection.Models
{
    public class ResponseEntity
    {
        public ResponseEntity()
        {
            public string Action { get; set; }
            public string Error { get; set; }
            public string Status { get; set; }
            public ResponseData ImageResponse { get; set; }
        }
    }
}

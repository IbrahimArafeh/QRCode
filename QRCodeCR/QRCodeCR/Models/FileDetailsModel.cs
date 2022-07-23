using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QRCodeCR.Models
{
    public class FileDetailsModel
    {
        public int Id { get; set; }
        [Display(Name = "Uploaded File")]
        public String FileName { get; set; }
        public byte[] FileContent { get; set; }
    }
}
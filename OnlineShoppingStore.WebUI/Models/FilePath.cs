using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.WebUI.Models
{
    using System.ComponentModel.DataAnnotations;  
    public class FilePath
    {
        public int FilePathId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
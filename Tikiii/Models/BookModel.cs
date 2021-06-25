using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tikiii.Models
{
    public class BookModel
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Không Được Để Trống Tên Sách")]
        public String title { set; get; }
        [Required(ErrorMessage = "Không Được Để Trống Tên Tác Giả")]
        public String author { set; get; }
        public String description { set; get; }
        public HttpPostedFileBase avatar { set; get; }
        [Required(ErrorMessage = "Không Được Để Trống Giá")]
        [Range(1000,1000000,ErrorMessage ="Giá Từ 1000 tới 1.000.000đ")]
        public int price { set; get; }
        public int status { set; get; }
    }
}
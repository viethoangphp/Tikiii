namespace Tikiii.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int id { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Author { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Avatar { get; set; }

        public int? Price { get; set; }

        public int? Status { get; set; }
    }
}

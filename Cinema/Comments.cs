namespace Cinema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        public int Comment_Id { get; set; }

        public int Cinema_Id { get; set; }

        public int Movie_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Comment { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Users Users { get; set; }
    }
}

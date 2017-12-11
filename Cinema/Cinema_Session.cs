namespace Cinema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cinema_Session
    {
        [Key]
        public int Cinema_Session_Id { get; set; }

        public int Cinema_Id { get; set; }

        public int Session_Id { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual Session Session { get; set; }
    }
}

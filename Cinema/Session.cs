namespace Cinema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class Session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session()
        {
            Cinema_Session = new HashSet<Cinema_Session>();
        }

        [Key]
        public int Session_Id { get; set; }

        public DateTime Date_time { get; set; }

        public int Hall_Id { get; set; }

        public int Movie_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cinema_Session> Cinema_Session { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movie Movie { get; set; }
    }
}

namespace winformtest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(6)]
        public string id { get; set; }

        [StringLength(40)]
        public string name { get; set; }

        [StringLength(10)]
        public string day { get; set; }

        [StringLength(3)]
        public string classId { get; set; }

        public virtual Class Class { get; set; }
    }
}

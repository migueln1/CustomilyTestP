using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomilyNETTest.Models.Common
{
    public class BaseEntity<T> where T : struct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
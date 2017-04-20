using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dbSqlDati.App_model
{
    [Table("GeoChrono")]
    public class CronoPosizione
    {
        [Key]
        public Guid Id
        { get; set; } = new Guid();

        public string Citta
        { get; set; }

        public DateTime Data
        { get; set; }
    }
}

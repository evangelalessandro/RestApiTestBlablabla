using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dbSqlDati.App_model
{
    [Table("Companies")]
    public class Company
    {
        [Key]
        public Guid Id
        { get; set; }

        [Required]
        public string Name
        { get; set; }

        [Required]
        public string Nation
        { get; set; }

        public string PersonaDiRiferimento
        { get; set; }

        public List<Riferimento> Riferimenti
        { get; set; }
    }
}

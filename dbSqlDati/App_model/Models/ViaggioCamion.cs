using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dbSqlDati.App_model
{
    public class ViaggioMachine
    {
        [Key]
        public Guid id
        { get; set; }

        public CronoPosizione  Partenza
        { get; set; }

        public CronoPosizione Arrivo
        { get; set; }

        public Machine Machine
        { get; set; }


        public List<Spazio> SpaziLiberi
        { get; set; }
    }
}

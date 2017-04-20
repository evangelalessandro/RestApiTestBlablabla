using System;
using System.ComponentModel.DataAnnotations;

namespace dbSqlDati.App_model
{
    public class Machine
    {
        [Key]
        public Guid id
        { get; set; }

        public string Name
        { get; set; }

        public string Nation
        { get; set; }
        
        [EnumDataType(typeof(TipoCamion))]
        public TipoCamion TipoCamion
        { get; set; }

        public Company CompanyRef
        { get; set; }
    }
}

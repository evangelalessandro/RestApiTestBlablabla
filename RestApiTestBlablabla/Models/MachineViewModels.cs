using System;
using System.Collections.Generic;

namespace RestApiTestBlablabla.Models
{
    // Models returned by MAchineController actions.

    public class MachineViewModel
    {
        public Controllers.TipoCamion TipoCamion { get; set; }

        public DateTime DataPartenza { get; set; }

        public DateTime DataArrivo { get; set; }

        public string CittaPartenza { get; set; }

        public string CittaArrivo { get; set; }

        public string Company { get; set; }
    }


}

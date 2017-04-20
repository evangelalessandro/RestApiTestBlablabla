using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbSqlDati;
using dbSqlDati.App_model;

namespace RestApiTestBlablabla.Controllers
{
    public class MachinesController : Controller
    {
        // GET: Machines
        public ActionResult Index()
        {
            return Json(new { nane = "Alessandro" });

        }
        // GET: Machines
        public ActionResult Add(Company company)
        {
            using (var db = new MachineDbContext())
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return Json(new { nane = "Alessandro" });

            }
        }
        [HttpPost]
        public ActionResult AggiornaNome(string nome)
        {
            return Json(new { nane = nome });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cittaSorgente">Città partenza</param>
        /// <param name="cittaDestinazione">Città destinazione</param>
        /// <param name="dateInizio">Data partenza</param>
        /// <param name="dataFine">Data arrivo</param>
        /// <returns>ricerca macchine che passino per la citta sorgente fino alla città destinazione, per tipo, per spazio disponibile e date di passaggio possibili</returns>
        public ActionResult Search(string cittaSorgente,
            string cittaDestinazione,
            TipoCamion tipoCamion, int? metriLineariDisponibili,
            int? metriCubiDisponibili, int? casseDisponibili,
            DateTime? dateInizio, DateTime? dataFine)
        {
            if (dateInizio.HasValue)
            {
            }
            return Json(new { nane = "Alessandro" });
        }
    }
}
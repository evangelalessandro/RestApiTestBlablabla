using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;

namespace dbSqlDati.App_model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var db = new dbSqlDati.App_model.MachineDbContext())
            {

                var riferimenti = new System.Collections.Generic.List<Riferimento>();
                riferimenti.Add(new Riferimento()
                {
                    TipoRiferimento = TipoRiferimento.cellulare1,
                    Dato = "349343434"
                });
                riferimenti.Add(new Riferimento()
                {
                    TipoRiferimento = TipoRiferimento.cellulare2,
                    Dato = "344 53532235"
                });

                db.Companies.Add(new dbSqlDati.App_model.Company()
                {
                    Id = Guid.NewGuid(),
                    Name = "Azienda",
                    Nation = "Italia",
                    PersonaDiRiferimento = "Persona Riferimento",
                    Riferimenti = riferimenti
                });
                db.SaveChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                using (var azienda = new MyRepository<Company>(db))
                {
                    var dato = azienda.GetAll().Where(a => a.Name == "Azienda").Select(a=> 
                    new {Riferimento= a.Riferimenti, Dati= a}).FirstOrDefault();

                    if (dato != null)
                    {
                        this.Text = dato.Dati.Id.ToString();
                    }
                }
            }
        }
    }
}

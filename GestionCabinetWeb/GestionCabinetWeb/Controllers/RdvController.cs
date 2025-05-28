using Microsoft.AspNetCore.Mvc;
using GestionCabinetWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionCabinetWeb.Controllers
{
    public class RdvController : Controller
    {
        private readonly CabinetMedicalContext _context; // remplace par le nom réel de ton DbContext

        public RdvController(CabinetMedicalContext context)
        {
            _context = context;
        }

        // Affiche le formulaire
        public IActionResult Index()
        {
            return View();
        }

        // Traite le numéro et affiche les rdvs
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> Resultats(string telephone)
        {
            var patient = await _context.Patients
                .Include(p => p.Rdvs)
                .FirstOrDefaultAsync(p => p.Telephone == telephone);

            if (patient == null)
            {
                ViewBag.Message = "Aucun patient trouvé.";
                return View("Index");
            }

            var maintenant = DateTime.Now;

            var rdvsAVenir = patient.Rdvs
                .Where(r => r.DateRdv >= maintenant)
                .OrderBy(r => r.DateRdv)
                .ToList();

            if (rdvsAVenir.Any())
            {
                return View(rdvsAVenir); // Vue avec les rendez-vous à venir
            }
            else
            {
                var dernierRdv = patient.Rdvs
                    .OrderByDescending(r => r.DateRdv)
                    .FirstOrDefault();

                if (dernierRdv != null)
                {
                    ViewBag.Message = $"Votre dernier rendez-vous est déjà passé, c'était le {dernierRdv.DateRdv:dd/MM/yyyy à HH:mm}.";
                }
                else
                {
                    ViewBag.Message = "Aucun rendez-vous enregistré.";
                }

                return View("Index");
            }
        }

    }
}

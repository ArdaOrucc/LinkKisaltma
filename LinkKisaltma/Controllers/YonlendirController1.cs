using LinkKisaltma.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkKisaltma.Controllers
{
    public class YonlendirController1 : Controller
    {
        [Route("/{GelenLink)")]
        public IActionResult Index(string GelenLink)
        {

            DatabaseContext db = new DatabaseContext();
            var BulunanData = db.Links.Where(x =>x.KisaLink == GelenLink).FirstOrDefault();

            if (BulunanData == null)
            {
                return Redirect(BulunanData.UzunLink);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }
    }
}

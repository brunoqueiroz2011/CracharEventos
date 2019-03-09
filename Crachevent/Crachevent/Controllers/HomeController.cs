using Crachevent.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Crachevent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.img = "~/Content/Imagens/cracha01.png";
            return View();
        }

        /*public interface IFormFile
        {
            string ContentType { get; }
            string ContentDisposition { get; }            
            long Length { get; }
            string Name { get; }
            string FileName { get; }
            Stream OpenReadStream();
            void CopyTo(Stream target);
            Task CopyToAsync(Stream target, CancellationToken cancellationToken);
        }

        [HttpPost]
        public void PostImg(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            //return Ok(new { count = files.Count, size, filePath });
        }*/

        public ActionResult About()
        {
            ViewBag.Message = "Descrição do Crachevent.";

            return View();
        }

        public ActionResult Contact()
        {            
            ContactViewModel contactView = new ContactViewModel();
            contactView.name = "Bruno Gonçalves de Queiroz";
            contactView.city = "Jaboatão dos Guararapes";
            contactView.street = "Rua da Baixa";
            contactView.number = "N° 281";
            contactView.phoneNumber = "+55(81) 98815 - 2927";
            contactView.email = "bruno.queiroz2011@gmail.com";
            contactView.linkedin = "brunogoncalvesqueiroz";
            contactView.github = "brunoqueiroz2011";
            contactView.wordpress = "brunogoncalvesqueiroz.wordpress.com/";

            return View(contactView);
        }
    }
}
using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeGames.Controllers
{
    
    public class VideoGController : Controller
    {

        private ApplicationDbContext _context;

        public VideoGController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult IndexConsole()
        {
            var videoGameIndexview = new VideoGIndexViewModel()
            {
                VideoGs = _context.VideoGs.ToList()
            };

            return View(videoGameIndexview);
        }


        public ActionResult DetalhesVideoGame(int id)
        {
            if (id > _context.VideoGs.Count()) return HttpNotFound();

            VideoG videoDetalhe = _context.VideoGs.Find(id);//(clientes => clientes.Id == id);

            return View(videoDetalhe);

        }

        public ActionResult New()
        {
            var viewModel = new VideoGIndexViewModel();

            return View("FormVideoGame", viewModel);
        }


        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(VideoG videoG)
        {
            ModelState.Remove("videoG.Id");

            if (!ModelState.IsValid)
            {
                var viewModel = new VideoGIndexViewModel
                {
                    VideoG = videoG
                };

                return View("FormVideoGame", viewModel);
            }

            if (videoG.Id != 0)
            {
                _context.Entry(videoG).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _context.VideoGs.Add(videoG);
            }
            _context.SaveChanges();
            return RedirectToAction("IndexConsole");
        }

        public ActionResult Edit(int id)
        {
            var videoG = _context.VideoGs.SingleOrDefault(c => c.Id == id);

            if (videoG == null)
                return HttpNotFound();

            var viewModel = new VideoGIndexViewModel()
            {
                VideoG = videoG
            };

            return View("FormVideoGame", viewModel);
        }


        public ActionResult Delete(int id)
        {

            VideoG videoG = _context.VideoGs.SingleOrDefault(c => c.Id == id);

            if (videoG == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.VideoGs.Remove(videoG);
                _context.SaveChanges();
                return RedirectToAction("IndexConsole", videoG);
            }
        }
    }
}
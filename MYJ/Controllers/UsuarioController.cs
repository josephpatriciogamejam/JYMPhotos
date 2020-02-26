using MYJ.Data.Services.Repositories;
using MYJ.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYJ.Controllers
{
    public class UsuarioController : Controller
    {

        /// <summary>
        /// Constructor del repositorio
        /// </summary>
        public UsuarioRepository repositorio { get; set; }
        public UsuarioController()
        {
            repositorio = new UsuarioRepository();
        }


        // GET: Usuario
        public ActionResult Index()
        {
            List<Usuario> model = repositorio.GetAllUsuarios();
            return View(model);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    repositorio.CreateUsuarios(model);
                    return RedirectToAction("Index");
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(model);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

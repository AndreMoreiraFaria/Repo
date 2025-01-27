﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGarcom.Controllers
{
    public class CozinhaController : Controller
    {

        UnitOfWork.UnitOfWorkApp _uow;
        public CozinhaController()
        {
            _uow = new UnitOfWork.UnitOfWorkApp();
        }
        // GET: Cozinha
        public ActionResult Index()
        {
            return View(_uow.PedidoRepository.FindAll());
        }

        // GET: Cozinha/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cozinha/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cozinha/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cozinha/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cozinha/Edit/5
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

        // GET: Cozinha/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cozinha/Delete/5
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

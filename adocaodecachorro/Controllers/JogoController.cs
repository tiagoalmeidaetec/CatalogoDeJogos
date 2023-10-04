﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CatalogoDeJogos.Models;

namespace CatalogoDeJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            return View(JogoModel.CriarLista());
        }


        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View(JogoModel.CriarLista()[id]);
        }
        
        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(JogoModel.CriarLista()[id]);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jogo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        

        // POST: Aluno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
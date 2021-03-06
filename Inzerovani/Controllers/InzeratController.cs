﻿using Inzerovani.Mappers;
using Inzerovani.ServiceLayer;
using System.Web.Mvc;

namespace Inzerovani.Controllers
{
    public class InzeratController : Controller
    {
        private readonly IInzeratService inzeratService;
        private readonly IMapperWeb autoMapper;
        public InzeratController(IInzeratService inzeratService, IMapperWeb autoMapper)
        {
            this.inzeratService = inzeratService;
            this.autoMapper = autoMapper;
        }
        // GET: Inzerat
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }


    }
}

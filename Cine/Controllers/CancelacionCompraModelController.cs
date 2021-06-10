﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cine.Models;
using Cine.DAL;

namespace Cine.Controllers
{
    public class CancelacionCompraModelController : Controller
    {
        private CineContext db = new CineContext();

        public ActionResult Index(int id)
        {
            CancelacionCompraModel ccm = new CancelacionCompraModel { };

            if (id != 0)
            {
                // Ricardo le mete query a db buscando id
                // cancela la compra
                // setea ccm
            }

            return View(ccm);
        }
    }
}
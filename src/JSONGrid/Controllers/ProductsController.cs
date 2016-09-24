using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using JSONGrid.Models;
using JSONGrid.Repository.Abstract;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace JSONGrid.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetJson()
        {
            _repository.GenerateJson();
            JObject Products = JObject.Parse(System.IO.File.ReadAllText(@"Products.json"));
            return Json(Products);
        }

    }
}

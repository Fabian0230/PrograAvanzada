﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ulatina.PrograAvanzada.Model;

namespace Ulatina.PrograAvanzada.AdventureWorks
{
    public class ProductsController : Controller
    {
        private AdventureWorksContext db = new AdventureWorksContext();

        // GET: Products
        public ActionResult Index()
        {
            //var products = db.Products.Include(p => p.ProductModel).Include(p => p.ProductSubcategory);
            decimal elPrecioInferior = 25;
            decimal elPrecioSuperior = (decimal)55.6;
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Acciones.Productos();
            var products = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior,elPrecioSuperior);
            return View(products.ToList());
        }

        public ActionResult IndexViewModel()
        {
            //var products = db.Products.Include(p => p.ProductModel).Include(p => p.ProductSubcategory);
            decimal elPrecioInferior = 25;
            decimal elPrecioSuperior = (decimal)55.6;
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Acciones.Productos();
            var products = laAccion.BuscarProductoPorRangoDePrecio(elPrecioInferior, elPrecioSuperior);
            var laAccionViewModel = new Dominio.Acciones.ConvertirProductEnViewModel();
            var productsViewModel = laAccionViewModel.ConviertaListaDeProductos(products);
            return View(productsViewModel.ToList());
        }
        //Primera consulta Proyecto
        public ActionResult IndexViewModel1()
        {   
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Acciones.Productos();
            var products = laAccion.EncontrarProductoPorNombre("Crankarm");
            var laAccionViewModel = new Dominio.Acciones.ConvertirProductEnViewModel();
            var productsViewModel = laAccionViewModel.ConviertaListaDeProductos(products);
            return View(productsViewModel.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult MisDetallesPorProductNumber(string productNumber)
        {
            if (productNumber == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var laAccion = new Ulatina.PrograAvanzada.AW.WCF.Acciones.Productos();
            Product product = laAccion.EncontrarProductoPorNumero(productNumber);
            //Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name");
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name");
            return View();
        }

        // POST: Products/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,rowguid,ModifiedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // POST: Products/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,rowguid,ModifiedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

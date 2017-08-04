using System;
using System.Collections.Generic;
using System.Linq;

namespace Ulatina.PrograAvanzada.AW.WCF.Repositorio
{
    //tarea moral:
    /*Genere el codigo en linq para las siguientes consultas:
     1.lista de articulos que contienen una hilera(string) determinada en el nombre.
     2.lista de articulos cuya fecha de vencimiento sea menor o igual a una determinada fecha.
     3.lista de articulos de un color determinado.
     4.lista de articulos cuyo nombre de la subcategoria contenga una hilera determinada.
     5.lista de articulos cuyo nombre de la categoria contenga una hilera determinada.
     6.lista de articulos cuyo nombre de modelo contenga una hilera determinada.
     7.lista de articulos que contengan al menos un review.*/
    internal class Productos
    {
        //me dice a cuales tablas tengo acceso
        static Model.AdventureWorks2014Entities _Contexto = new Model.AdventureWorks2014Entities();
        
        public Productos()
        {
        }
        //Primer consulta Proyecto
        public IList<Model.Product> BuscarProductoPorNombre(string elNombre)
        {
            var losProductos = _Contexto.Product.Where(p => p.Name.Contains(elNombre)).ToList();
            return losProductos;
        }

        public Model.Product EncontrarProductoPorNumero(string elNumero)
        {
            Model.Product elProducto = new Model.Product();
            elProducto= _Contexto.Product.Include("ProductSubCategory").Include("ProductModel").Include ("ProductReview").Include("ProductSubCategory.ProductCategory").Where(p => p.ProductNumber.Equals(elNumero)).FirstOrDefault(); 
            return elProducto;
        }

            public IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior)
        {
            var losProductos = _Contexto.Product.Where(p => elPrecioInferior <= p.ListPrice && p.ListPrice <= elPrecioSuperior).ToList();
            return losProductos;
        }
    }
}
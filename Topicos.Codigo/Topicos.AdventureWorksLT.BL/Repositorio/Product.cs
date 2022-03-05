using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.AdventureWorksLT.Model.Models;

namespace Topicos.AdventureWorksLT.BL.Repositorio
{
    internal class Product
    {
        private readonly AdventureWorksLT2019Context _contexto = new();
        private readonly int _pagesize = 10;

        public Product()
        {
        }
        public Product(int pagesize)
        {
            _pagesize = pagesize;
        }

        public Model.Models.Product? BuscarPorID(int id)
        {
            var resultado = _contexto.Products.Find(id);
            return resultado;
        }

        public async Task<IList<Model.Models.Product>> BuscarTodos(int pageNumber = 0)
        {
            var resultado = _contexto.Products.Skip(_pagesize * pageNumber).Take(_pagesize).OrderBy(c => c.ProductId).ToListAsync();
            return await resultado;
        }

        //public IList<Model.Models.Product> BuscarPorDescripcion(string hilera, int pageNumber = 0)
        //{
        //    var resultado = _contexto.Products.Include(c => c.ProductModel).ThenInclude(ca => ca.Products).Where(
        //        c => c.ProductModel.Any(a => a.Address.CountryRegion.Contains(hilera)))
        //        .Skip(_pagesize * pageNumber).Take(_pagesize).
        //        OrderBy(c => c.CustomerId).ToList();
        //    return resultado;
        //}

        //public IList<Model.Models.Customer> BuscarPorCountry(string hilera, int pageNumber = 0)
        //{
        //    var resultado = _contexto.Customers.Include(c => c.CustomerAddresses).ThenInclude(ca => ca.Address).Where(
        //        c => c.CustomerAddresses.Any(a => a.Address.CountryRegion.Contains(hilera)))
        //        .Skip(_pagesize * pageNumber).Take(_pagesize).
        //        OrderBy(c => c.CustomerId).ToList();
        //    return resultado;
        //}


    }
}

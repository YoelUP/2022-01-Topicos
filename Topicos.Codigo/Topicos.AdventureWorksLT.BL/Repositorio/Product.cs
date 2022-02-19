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

        public Model.Models.Product? BuscarPorID(int id)
        {
            var resultado = _contexto.Products.Find(id);
            return resultado;
        }

        public IList<Model.Models.Product> BuscarTodos()
        {
            var resultado = _contexto.Products.ToList();
            return resultado;
        }
    }
}

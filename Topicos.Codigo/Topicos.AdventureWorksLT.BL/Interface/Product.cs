using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.AdventureWorksLT.BL
{
    public class Product
    {
        public Model.Models.Product? BuscarPorID(int id)
        {
            var elRepositorio = new Repositorio.Product();
            var elResultado = elRepositorio.BuscarPorID(id);
            return elResultado;
        }

        public IList<Model.Models.Product> BuscarTodos()
        {
            var elRepositorio = new Repositorio.Product();
            var elResultado = elRepositorio.BuscarTodos();
            return elResultado;
        }
    }
}

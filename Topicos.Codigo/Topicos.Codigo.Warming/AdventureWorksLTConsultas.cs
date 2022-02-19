using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Codigo.Warming
{
    public class AdventureWorksLTConsultas
    {

        public void MenuPrincipal()
        {
            string? opcion = String.Empty;
            while (opcion != "0")
            {
                DesplegarMenu();
                opcion = CapturarOpcion();
                EjecutarOpcion(opcion);
            }

        }

        private void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1": 
                    ConsultarPorId();
                    break;

                case "2":
                    //ConsultarPorNombreOApellido();
                    break;
                case "3":
                    ConsultarProductos();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opcion Errorena");
                    break;


            }
        }

        private void ConsultarProductos()
        {
            var laLogicaDeNegocio = new AdventureWorksLT.BL.Product();
            var losProductos = laLogicaDeNegocio.BuscarTodos();
            if (losProductos.Count == 0)
            {
                Console.WriteLine("No Encuntrados");
            }
            else
            {
                foreach (var producto in losProductos)
                {
                    ImprimaProducto(producto);
                }

            }
        }

        private void ConsultarPorNombreOApellido()
        {
            var laLogicaDeNegocio = new AdventureWorksLT.BL.Product();
            var losProductos = laLogicaDeNegocio.BuscarTodos();
            if (losProductos.Count == 0)
            {
                Console.WriteLine("No Encuntrados");
            }
            else
            {
                foreach (var producto in losProductos)
                {
                    ImprimaProducto(producto);
                }
               
            }
        }

        private void ConsultarPorId()
        {
            //Console.WriteLine("Digite el ID del Customer:");
            //var customerId = Console.ReadLine();
            //var customerIdInt = 0;
            //if (int.TryParse(customerId, out customerIdInt))
            //{
            //    var laLogicaDeNegocio = new AdventureWorksLT.BL.Customers();
            //    var elCustomer = laLogicaDeNegocio.BuscarPorID(customerIdInt);
            //    if (elCustomer == null)
            //    {
            //        Console.WriteLine("El customer no se Encontro");
            //    }
            //    else
            //    {
            //        ImprimaCustomer(elCustomer);
            //    }
            //}

        }

        private void ImprimaCustomer(AdventureWorksLT.Model.Models.Customer elCustomer)
        {
            Console.WriteLine($"Id: { elCustomer.CustomerId},  Nombre: {elCustomer.FullName}, Telefono: {elCustomer.Phone} ");
        }

        private string? CapturarOpcion()
        {
            Console.WriteLine("Digite la opcion deseada: ");
            var opcion = Console.ReadLine();
            return opcion;
        }

        public void DesplegarMenu()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1 Consultar Customer por ID");
            Console.WriteLine("2 Consultar Customers por Nombre o Apellido");
            Console.WriteLine("3 Consultar Productos");
            Console.WriteLine("0 Salir");
        }


        private void ImprimaProducto(AdventureWorksLT.Model.Models.Product elProducto)
        {
            Console.WriteLine($"Id: { elProducto.ProductId}, Nombre: {elProducto.Name}, Tiempo En Venta: {elProducto.TiempoQueEstuvoEnVenta}");
        }
    }
}

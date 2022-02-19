using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.AdventureWorksLT.Model.Models
{
    public partial class Product
    {
        [NotMapped]
        /*Una propiedad que indique cuánto tiempo en meses y días estuvo en venta el producto
        TiempoQueEstuvoEnVenta*/

        public string TiempoQueEstuvoEnVenta
        {
            get
            {
                if (this.DiscontinuedDate == null)
                {
                    this.DiscontinuedDate = DateTime.Now;
                }
                TimeSpan diferencia = Convert.ToDateTime(this.DiscontinuedDate) - Convert.ToDateTime(this.SellStartDate);

                return diferencia.ToString();
            }
            set
            {}
        }


        /*Una propiedad que indique desde hace cuánto tiempo el producto está descontinuado
        TiempoQueLlevaDescontinuado*/
        //public TimeSpan TiempoQueLlevaDescontinuado
        //{
        //    get
        //    {

        //        DateTime Discontinued;
        //        DateTime SellStar;
        //        TimeSpan difFechas;

        //        //= Convert.ToDateTime(this.DiscontinuedDate)

        //        // = Convert.ToDateTime(this.SellStartDate)
        //        //TimeSpan difFechas = Discontinued - SellStar;


        //        if (this.DiscontinuedDate == null)
        //        {
        //            Discontinued = Convert.ToDateTime(DateTime.Now);
        //        }
        //        SellStar = Convert.ToDateTime(this.SellStartDate);
        //        difFechas = Discontinued - SellStar;


        //        return difFechas;
        //    }
        //    set
        //    {

        //    }
        //}
    }
}

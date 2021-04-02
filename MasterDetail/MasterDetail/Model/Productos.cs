using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Model
{
    public class Productos
    {
        public string Id { set; get; }

        public string Nombre { set; get; }

        public string Descripcion { set; get; }

        public string Precio { set; get; }

        public string URL { set; get; }

        public string Cantidad { set; get; }

        public string Codigo { set; get; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}

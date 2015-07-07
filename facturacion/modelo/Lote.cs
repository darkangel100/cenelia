using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facturacion.modelo
{
    class Lote
    {
        private int id_Lote;
        private DateTime fechcad;
        private DateTime fechelab;
        private string stock;
        private double pv;
        private double pc;
        private DateTime caduca;
        private List<Lote> listaLote = new List<Lote>();

        internal List<Lote> ListaLote
        {
            get { return listaLote; }
            set { listaLote = value; }
        }
        public int Id_Lote
        {
            get { return id_Lote; }
            set { id_Lote = value; }
        }

        public DateTime Fechcad
        {
            get { return fechcad; }
            set { fechcad = value; }
        }

        public DateTime Fechelab
        {
            get { return fechelab; }
            set { fechelab = value; }
        }

        public string Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public double Pv
        {
            get { return pv; }
            set { pv = value; }
        }

        public double Pc
        {
            get { return pc; }
            set { pc = value; }
        }
       

        public DateTime Caduca
        {
            get { return caduca; }
            set { caduca = value; }
        }

    }
}

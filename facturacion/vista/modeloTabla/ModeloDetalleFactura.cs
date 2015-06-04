using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace facturacion.vista.modeloTabla
{
    class ModeloDetalleFactura
    {
        private DataGridView tabla;
        private List<object> lista = new List<object>();

        public List<object> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        public DataGridView Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }
        public int filas()
        {
            return (this.lista.Count > 0) ? this.lista.Count : 1;
        }
        public void llenarTabla()
        {
            //this.tabla = new DataGridView(); 
            this.tabla.Columns.Clear();
            this.tabla.DataSource = null;
            this.tabla.AutoGenerateColumns = false;
            this.tabla.RowCount = this.filas();
            this.tabla.DataSource = this.lista;
            this.textoColumnas();        
            
                            
        }
        private void textoColumnas()
        {
            this.tabla.Columns.RemoveAt(0);
            
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.DataPropertyName = "cantidad";
            c1.HeaderText = "Cant";
            c1.Width = 100;            
            this.tabla.Columns.Add(c1);
            
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.DataPropertyName = "detalle";
            c2.HeaderText = "Detalle";
            c2.Width = 100;
            this.tabla.Columns.Add(c2);
            

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.DataPropertyName = "pvp";
            c3.HeaderText = "P/U";
            c3.Width = 100;
            this.tabla.Columns.Add(c3);
            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.DataPropertyName = "total";
            c4.HeaderText = "Total";
            c4.Width = 100;
            this.tabla.Columns.Add(c4);
        }

    }
}

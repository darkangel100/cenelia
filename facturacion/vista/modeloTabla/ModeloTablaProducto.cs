using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace facturacion.vista.modeloTabla
{
    class ModeloTablaProducto
    {
        private DataGridView tabla;
        private List<object> lista = new List<object>();

        internal List<object> Lista
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
            //MessageBox.Show(this.filas()+"");
            this.textoColumnas();
            tabla.DataSource = lista;

        }
        private void textoColumnas()
        {
            this.tabla.Columns.RemoveAt(0);
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.DataPropertyName = "codigo";
            c1.HeaderText = "Código";
            c1.Width = 100;
            this.tabla.Columns.Add(c1);
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.DataPropertyName = "nombre";
            c2.HeaderText = "Nombre";
            c2.Width = 100;
            this.tabla.Columns.Add(c2);
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.DataPropertyName = "pvp";
            c3.HeaderText = "PVP";
            c3.Width = 100;
            this.tabla.Columns.Add(c3);
            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.DataPropertyName = "stock";
            c4.HeaderText = "Stock";
            c4.Width = 100;
            this.tabla.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.DataPropertyName = "detalle";
            c5.HeaderText = "Detalle";
            c5.Width = 100;
            this.tabla.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.DataPropertyName = "estado";
            c6.HeaderText = "Estado";
            c6.Width = 100;
            this.tabla.Columns.Add(c6);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo06_SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Categoria", "Categoría");
            dataGridView1.Columns.Add("Stock", "Stock");
            dataGridView1.Columns.Add("Precio", "Precio");

            dataGridView1.Rows.Add("1", "Laptop", "Lenovo", "Computadoras", "15", "2500.00");
            dataGridView1.Rows.Add("2", "Mouse", "Logitech", "Accesorios", "40", "45.00");
            dataGridView1.Rows.Add("3", "Teclado", "Redragon", "Accesorios", "25", "120.00");
            dataGridView1.Rows.Add("4", "Monitor", "Samsung", "Pantallas", "10", "650.00");
            dataGridView1.Rows.Add("5", "Impresora", "Epson", "Impresoras", "8", "780.00");
            dataGridView1.Rows.Add("6", "Disco Duro", "Seagate", "Almacenamiento", "20", "320.00");
            dataGridView1.Rows.Add("7", "Memoria RAM", "Kingston", "Componentes", "30", "180.00");
            dataGridView1.Rows.Add("8", "Audífonos", "Sony", "Audio", "18", "210.00");
            dataGridView1.Rows.Add("9", "Webcam", "Logitech", "Accesorios", "12", "150.00");
            dataGridView1.Rows.Add("10", "Router", "TP-Link", "Redes", "14", "230.00");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

}

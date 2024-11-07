using SistemaVendas.BLL_Classes;
using SistemaVendas.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.UI_formularios
{
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            InitializeComponent();
        }
        userBLL_Class u = new userBLL_Class();
        userDAL_Class dal = new userDAL_Class();
        private object dvgusuario;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmUsiarios_Load(object sender, EventArgs e)
        {

        }
    }

    internal class userBLL_Class
    {
    }
}

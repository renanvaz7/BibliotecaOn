using BibliotecaOnRenan.Controller;
using BibliotecaOnRenan.Model;
using BibliotecaOnRenan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaOnRenan
{
    public partial class frmPrincipal : Form
    {
        private Form currentChildForm;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwn, int wMsg, int wParam, int lParam);
        
        private void pnlContent_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ibtnAdicionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdicionar());
        }

        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditar());
        }

        private void ibtnListar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListar());
        }

        private void ibtnRemover_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRemover());
        }

        private void ibtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

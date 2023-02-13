using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MikaSafePass.Helper;

namespace MikaSafePass
{
    public partial class NewDataBaseForm : Form
    {
        public NewDataBaseForm()
        {
            InitializeComponent();
        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = !textBoxPass.UseSystemPasswordChar;
        }

        private void btnTogglePass2_Click(object sender, EventArgs e)
        {
            textBoxConfirm.UseSystemPasswordChar= !textBoxConfirm.UseSystemPasswordChar;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Equals(textBoxConfirm.Text))
            {
                ((MainForm)Owner).Database.Hash = Security.GetHash(textBoxPass.Text);
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !", "MikaSafePass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult= DialogResult.None;
            }
        }
    }
}

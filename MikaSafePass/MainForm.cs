using MikaSafePass.Entity;
using MikaSafePass.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikaSafePass
{
    public partial class MainForm : Form
    {
        public DataBase Database;

        private readonly Config configuration;
        public MainForm()
        {
            InitializeComponent();
            Database= new DataBase();
            configuration= new Config();

            FormClosing += MainForm_FormClosing;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigHelper.SaveConfig(configuration);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void MenuNvo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                FileName = "Base de donnees.mpm",
                Filter = "Fichier MPM de MikaSafePass | *.mpm"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dataFichier = sfd.FileName;
                NewDataBaseForm newDataBaseForm = new();

                if (newDataBaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.ListEntree = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.ListEntree;
                    configuration.DerniereEntree = dataFichier;

                    DatabaseHelper.SauvegardeDatabase(dataFichier, Database);

                    Text = $"MikaSafePass - {Path.GetFileName(dataFichier)}";

                }

            }
        }

    }
}
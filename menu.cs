using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace lab2
{
    public partial class menu : Form
    {
        private Form1 mainForm = null;
        public menu(Form callingForm)
        {
            mainForm = callingForm as Form1; 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void zamknijMenu(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void atrybuty(FileSystemInfo info, string sciezka){ }

        private void rob(string nazwa) {
            string sciezka;
            TreeNode zaznaczony = this.mainForm.treeView1.SelectedNode;
            string pelna = this.mainForm.glowny + zaznaczony.FullPath;
            FileAttributes attr = File.GetAttributes(this.mainForm.glowny + zaznaczony.FullPath);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                sciezka = this.mainForm.glowny + zaznaczony.FullPath + "\\" + nazwa;

            else
            {
                sciezka = this.mainForm.glowny + zaznaczony.FullPath;
                sciezka = sciezka.Remove(pelna.Length - zaznaczony.Text.Length - 1) + "\\" + nazwa;
            }
            

            if (Plik.Checked)
            {
                File.Create(sciezka).Dispose();
               
            }
            else
            {
                var di = Directory.CreateDirectory(sciezka);


            }
            File.SetAttributes(sciezka, FileAttributes.Normal);
            if (ReadOnly.Checked)
                File.SetAttributes(sciezka, File.GetAttributes(sciezka) | FileAttributes.ReadOnly);
            if (Archive.Checked)
                File.SetAttributes(sciezka, File.GetAttributes(sciezka) | FileAttributes.Archive);
            if (System.Checked)
                File.SetAttributes(sciezka, File.GetAttributes(sciezka) | FileAttributes.System);
            if (Hidden.Checked)
                File.SetAttributes(sciezka, File.GetAttributes(sciezka) | FileAttributes.Hidden);

            var nowy = new TreeNode(nazwa);
            zaznaczony.Nodes.Add(nowy);
            Dispose();
            this.Close();
        }
        
        private void ok(object sender, EventArgs e)
        {
            string nazwa = this.textBox1.Text;
 
            Regex rgx = new Regex("^[a-zA-Z0-9_~-]{1,8}.(txt|php|hml){1}$");
            if (Plik.Checked)
            {
                if (rgx.IsMatch(nazwa))
                {
                    rob(nazwa);
                }
                else
                {
                    this.Close();

                }

            }
            else
                rob(nazwa);

        }
    }
}

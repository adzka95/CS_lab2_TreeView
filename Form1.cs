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
    public partial class Form1 : Form
    {
        public string glowny;
        FolderBrowserDialog dialog;
        public Form1()
        {
            InitializeComponent();
        }

        private void lolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello, World!");
        }

        private static TreeNode buduj(DirectoryInfo sciezka)
        {
            var wezel = new TreeNode(sciezka.Name);
            //wezel.Name = sciezka.FullName;
            foreach (var folder in sciezka.GetDirectories())
                wezel.Nodes.Add(buduj(folder));
            foreach (var plik in sciezka.GetFiles())
            {
                var nowy = new TreeNode(plik.Name);
                //nowy.Name = plik.FullName;
                //wezel.Nodes.Add(new TreeNode(plik.Name));
                wezel.Nodes.Add(nowy);

            }
            return wezel;
        }

        

        private void otworz(object sender, EventArgs e)
        {
            
            dialog = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult rezultat = dialog.ShowDialog();
            
            if (rezultat == DialogResult.OK)
            {
                
               string folderName = dialog.SelectedPath;
               glowny = folderName;
               treeView1.BeginUpdate();
               treeView1.Nodes.Clear();
               var lol = new DirectoryInfo(folderName);
               glowny = glowny.Remove(folderName.Length - lol.Name.Length);
               treeView1.Nodes.Add(buduj(lol));
               treeView1.ExpandAll();
               treeView1.EndUpdate();
               Console.WriteLine(folderName);
           
            }
        }

        private void zamknij(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj(object sender, EventArgs e)
        {
            
           menu opcje= new menu(this);
           opcje.Show();

        }

        void usunKatalog(DirectoryInfo  sciezka) {
            foreach (var folder in sciezka.GetDirectories())
                usunKatalog(folder);
            foreach (var plik in sciezka.GetFiles())
            {
                FileAttributes attr = File.GetAttributes(plik.FullName);
                if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    File.SetAttributes(plik.FullName, attr & ~FileAttributes.ReadOnly);
                File.Delete(plik.FullName);
            }
                
        }


        private void usun(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
            statusStrip1.Refresh();
            TreeNode treeNode=treeView1.SelectedNode;
            string nazwa = glowny + treeNode.FullPath;

            FileAttributes attr = File.GetAttributes(nazwa);
            if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                File.SetAttributes(nazwa, attr & ~FileAttributes.ReadOnly);
            
            ////detect whether its a directory or file
           
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                treeView1.Nodes.Remove(treeNode);
                usunKatalog(new DirectoryInfo(nazwa));
                Directory.Delete(nazwa, true);
            }
            else
            {

                FileAttributes attributes = File.GetAttributes(nazwa);
                treeView1.Nodes.Remove(treeView1.SelectedNode);
                File.Delete(nazwa);
            }

           
           Console.WriteLine("dodja");
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void zaznaczono(object sender, TreeViewEventArgs e)
        {
            TreeNode zaznaczono = treeView1.SelectedNode;
            FileAttributes a = File.GetAttributes(glowny + zaznaczono.FullPath);
            string wynik;
            if ((a & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                wynik = " r";
            else
                wynik = " -";
            if ((a & FileAttributes.Archive) == FileAttributes.Archive)
                wynik += "a";
            else
                wynik += "-";
            if ((a & FileAttributes.Hidden) == FileAttributes.Hidden)
                wynik += "h";
            else
                wynik += "-";
            if ((a & FileAttributes.System) == FileAttributes.System)
                wynik += "s";
            else
                wynik += "-";
            toolStripStatusLabel1.Text = wynik;// string.Format("Lines: "); ;
            statusStrip1.Refresh();
            string pattern = @"^*\.txt$";
            string sciezka = glowny + zaznaczono.FullPath;
            
            if (Regex.IsMatch(sciezka, pattern, RegexOptions.IgnoreCase))
            {
                StreamReader sr = new StreamReader(glowny + zaznaczono.FullPath);
                String line = sr.ReadToEnd();
                textBox1.Text = line;
                sr.Close();

            }
            else
                textBox1.Text = " ";
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        
    }
}

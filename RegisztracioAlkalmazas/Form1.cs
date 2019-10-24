using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hobbik.Items.Clear();
            hobbik.Items.Add("Uszás");
            hobbik.Items.Add("Horgászat");
            hobbik.Items.Add("Futás");
            
            ArrayList lista = new ArrayList();
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    using (var sr = new StreamReader(openFileDialog1.FileName))
                    {
                        hobbik.Items.Clear();
                        while (!sr.EndOfStream)
                        {
                            lista.Add(sr.ReadLine());
                        }
                        nev.Text = lista[0].ToString();
                        szuldatum.Text = lista[1].ToString();
                        if (lista[2].ToString().Equals("Férfi"))
                        {
                            f.Checked = true;
                        }
                        if (lista[2].ToString().Equals("Nő"))
                        {
                            n.Checked = false;
                        }
                        for (int i = 3; i < lista.Count; i++)
                        {
                            hobbik.Items.Add(lista[i].ToString());
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a betöltés!");
                }
                
            };
        
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            
            hobbik.Items.Add(ujhobbi.Text);
            ujhobbi.Text = "";
        }

        private void Mentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void N_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Betoltes_Click(object sender, EventArgs e)
        {

            hobbik.Items.Clear();
            openFileDialog1.ShowDialog();
            
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("Név:");
                    sw.WriteLine(nev.Text);
                    sw.WriteLine("Születési dátum:");
                    sw.WriteLine(szuldatum.Text);
                    sw.WriteLine("Kedvenc hobbik:");
                    sw.WriteLine("Nem:");
                    if (f.Checked)
                    {
                        sw.WriteLine("Férfi");
                    }
                    if (n.Checked)
                    {
                        sw.WriteLine("Nő");
                    }
                    foreach (var item in hobbik.Items)
                    {
                        sw.WriteLine(item);
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba. Sikertelen mentés!");
            }

        }

        private void Szuldatum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Szuldatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

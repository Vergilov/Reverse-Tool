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

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Przycisk do otwierania Pliku txt
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();//Otwieranie pliku
            open.Title = "Otworz Plik"; //Tytul okienka open
            open.Filter = "Pliki tekstowe |*.txt";
            if (open.ShowDialog()==DialogResult.OK)  {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                textBox1.Text = read.ReadToEnd();
                read.Dispose();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Przycisk do zamkniecia aplikacji
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Przycisk do otwierania okienka Form2
        private void ReverseToolButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textBox1.Text);
            f2.ShowDialog();
        }
    }
}

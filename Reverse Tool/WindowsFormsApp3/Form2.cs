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
    public partial class Form2 : Form
    {
        public Form2(string message)
        {
            InitializeComponent();
            textBox1.Text = message;
        }


        //Zachowanie Pliku tekstowego z TextBox
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Zachowaj Plik"; 
            save.Filter = "Pliki tekstowe|*.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(textBox1.Text);
                write.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Przycisk ktory zmienia ciag znaku w TextBoxie
        private void ReverseButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);
        }

        //Metoda zmieniająca kolejność znaków
        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        //Przycisk do zamykania aplikajci
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

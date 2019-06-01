using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            List<char> dictionary = new List<char>();
            Random rand = new Random();

            for (int i = 'a'; i <= 'z'; i++)
                dictionary.Add((char)i);
            if (box_upper.Checked)
                for (int i = 'A'; i <= 'Z'; i++)
                    dictionary.Add((char)i);
            if (box_numbers.Checked)
                for (int i = '0'; i <= '9'; i++)
                    dictionary.Add((char)i);
            if (box_rus.Checked)
                for (int i = 'а'; i <= 'я'; i++)
                    dictionary.Add((char)i);
            if (box_rusUpper.Checked)
                for (int i = 'А'; i <= 'Я'; i++)
                    dictionary.Add((char)i);
            string output = "";
            for (int i = 0; i < nud_length.Value; i++)
                output += dictionary[rand.Next(dictionary.Count)];
            txt_output.Text = output;
        }

        private void txt_output_TextChanged(object sender, EventArgs e)
        {
            nud_length.Value = txt_output.Text.Length;
        }
    }
}

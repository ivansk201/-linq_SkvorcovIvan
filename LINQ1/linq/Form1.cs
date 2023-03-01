using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace linq
{
    public partial class Form1 : Form
    {
        static void printTab(string w, Hashtable a)
        {
            var str = new StringBuilder();
            ICollection coll = a.Keys;
            str.AppendLine($"{w}");
            foreach (string i in coll)
            {
               str.AppendLine(i + " " + a[i]);
            }
            MessageBox.Show(str.ToString(), "Сообщение", MessageBoxButtons.OK);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prov = true;
            Hashtable people = new Hashtable();
            StreamReader fileIn = new StreamReader("people.txt");
            string peoples;
            while ((peoples = fileIn.ReadLine()) != null)
            {
                string[] temp = peoples.Split(' ');
                string name = temp[0] + " " + temp[1] + " " + temp[2];
                string ageandves = temp[3] + " " + temp[4];
                    if (int.Parse(temp[3]) < 40)
                        people.Add(name, ageandves);
               
            }
                printTab("Люди: ", people);
        }
    }
}

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
using System.Collections;

namespace Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct a
        {
            public string fio;
            public string iner;
            public string oger;
            public double age;
            public double ves;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        

       
        private void button1_Click(object sender, EventArgs e)
        {
            List<Departament> department = new List<Departament>()
            {
                new Departament { Namezvan = "Отдел закупок", Country ="Германия" },
                new Departament { Namezvan = "Отдел продаж", Country ="Испания" },
                new Departament { Namezvan = "Отдел маркетинга", Country ="Россия" }
            };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {Name2="Иванов", Dep ="Отдел закупок"},
                    new Employ {Name2="Петров", Dep ="Отдел закупок"},
                    new Employ {Name2="Сидоров", Dep ="Отдел продаж"},
                    new Employ {Name2="Лямин", Dep ="Отдел продаж "},
                    new Employ {Name2="Сидоренко", Dep ="Отдел маркетинга"},
                    new Employ {Name2="Кривоносов", Dep ="Отдел продаж "}
            };

            var result = from nm in employes
            join t in department on nm.Dep equals t.Namezvan
                         select new { Name = nm.Name2, Dep = nm.Dep, Country = t.Country };


            foreach (var item in result)
                if (item.Country.StartsWith("И"))
                    label1.Text = ($"{item.Name} - {item.Dep} ({item.Country})\n"+label1.Text);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            List<Departament> department = new List<Departament>()
            {
                new Departament { Namezvan = "Отдел закупок", Country ="Германия" },
                new Departament { Namezvan = "Отдел продаж", Country ="Испания" },
                new Departament { Namezvan = "Отдел маркетинга", Country ="Россия" }
            };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {Name2="Иванов", Dep ="Отдел закупок"},
                    new Employ {Name2="Петров", Dep ="Отдел закупок"},
                    new Employ {Name2="Сидоров", Dep ="Отдел продаж"},
                    new Employ {Name2="Лямин", Dep ="Отдел продаж "},
                    new Employ {Name2="Сидоренко", Dep ="Отдел маркетинга"},
                    new Employ {Name2="Кривоносов", Dep ="Отдел продаж "}
            };

            var result = from nm in employes
                         join t in department on nm.Dep equals t.Namezvan
                         select new { Name = nm.Name2, Dep = nm.Dep, Country = t.Country };

            

            foreach (var mb in result)
            {
                label1.Text = ($"{mb.Name} - {mb.Dep} ({mb.Country}) \n" + label1.Text);

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}

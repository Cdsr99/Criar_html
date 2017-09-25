using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criar_html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }
        public void html()
        {
            String ds = textBox1.Text;
            String name;
            name = textBox1.Text;
            string caminho = "C:\\Users\\Cdsr99\\Google Drive\\Programas\\HTML\\Practice\\" + ds + "\\" + name + ".html";
            //C:\\Users\\Cdsr99\\Google Drive\\Programas\\HTML\\Practice\\" + name\\name.html
            StreamWriter conteudo = new StreamWriter(caminho);
            //StreamReader conteudo02 = new StreamReader();
            conteudo.WriteLine("Test");
            conteudo.Write("test02");
            conteudo.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diretorio();
            html();
        }
       public void diretorio()
        {

            String name;
            name = textBox1.Text;
            String caminho = @"C:\Windows\Temp\Criador_pasta02.bat";


            StreamWriter pasta = new StreamWriter(caminho);
            pasta.WriteLine("c:");
            pasta.WriteLine(@"cd C:\Users\Cdsr99\Google Drive\Programas\HTML\Practice");
            pasta.WriteLine("md " + name);
            //pasta.WriteLine("pause");
            pasta.Close();

            Process chamar = new Process();
            chamar.StartInfo.FileName = caminho;
            chamar.Start();
            
        }

    }
    }


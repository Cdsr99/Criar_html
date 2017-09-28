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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void caminho()
        {
            String caminho_bat;
            String caminho_arq;
            String texto;

            caminho_bat = @"C:\Windows\Temp\Criador_pasta02.bat";

            StreamWriter bat = new StreamWriter(caminho_bat);
            bat.WriteLine("c:");
            bat.WriteLine("cd " + textBox1.Text);
            bat.WriteLine("md " + textBox2.Text);
            //bat.WriteLine("pause");
            bat.Close();

            Process chamar = new Process();
            chamar.StartInfo.FileName = caminho_bat;
            chamar.Start();

            
        }
        public void html()
        {
            String nome = textBox2.Text;
            String name;
            name = textBox1.Text;
            string caminho = textBox1.Text + "\\" + nome + "\\" + nome + ".html" ;
            //C:\\Users\\Cdsr99\\Google Drive\\Programas\\HTML\\Practice\\" + name\\name.html
            StreamWriter conteudo = new StreamWriter(caminho);
            //StreamReader conteudo02 = new StreamReader();
            conteudo.WriteLine("<!DOCTYPE html>");
            conteudo.WriteLine("<html>");
            conteudo.WriteLine("<head>");
            conteudo.WriteLine("	<title>Cdsr99</title>");
            conteudo.WriteLine("</head>");
            conteudo.WriteLine("<body>");
            conteudo.WriteLine("");
            conteudo.WriteLine("</body>");
            conteudo.WriteLine("</html>");
            conteudo.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            caminho();
            System.Threading.Thread.Sleep(5000);
            html();
        }
    }
}

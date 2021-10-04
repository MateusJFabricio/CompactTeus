using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCompact
{
    public partial class Form1 : Form
    {
        string arquivosPath = "C:\\temp\\arquivos";
        string compactPath = "C:\\temp\\compact.VPR";
        string extractPath = "C:\\temp\\extract";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string text =
            "A class is the most powerful data type in C#. Like a structure, " +
            "a class defines the data and behavior of the data type. ";

            Directory.CreateDirectory(arquivosPath);

            File.WriteAllText(arquivosPath + "\\WriteText.txt", text);
            File.WriteAllText(arquivosPath + "\\WriteText2.txt", text);

            ZipFile.CreateFromDirectory(arquivosPath, compactPath);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }
            ZipFile.ExtractToDirectory(compactPath, extractPath);
        }
    }
}

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

namespace MoneyController
{
    public partial class InfoConexao : Form
    {
        string cam = Directory.GetCurrentDirectory() + @"\config";
        public InfoConexao()
        {
            InitializeComponent();
            DirecCreate();
            SeeFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }
        private void DirecCreate()
        {
            if (Directory.Exists(cam))
                return;

            else
                Directory.CreateDirectory(cam);
        }
        private void SeeFile()
        {
            string rawFile = "";
            string[] configReady;
            if (File.Exists(cam + @"\conex.ecfg"))
            {
                using (StreamReader littleFile = new StreamReader(cam + @"\conex.ecfg"))
                {
                    rawFile = littleFile.ReadToEnd();
                    configReady = rawFile.Split('|');
                }
                DataSource.Text = configReady[0];
                BD.Text = configReady[1];
                Usuario.Text = configReady[2];
                Pass.Text = configReady[3];
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string ToFile = DataSource.Text + "|" + BD.Text + "|" + Usuario.Text + "|" + Pass.Text + "|";
            using(StreamWriter escritor = new StreamWriter(cam + @"\conex.ecfg"))
            {
                escritor.Write(ToFile);
            }
        }
    }
}

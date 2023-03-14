using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaFirmelor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public listadefirmesicompanii lfc = new listadefirmesicompanii();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            lfc.codlfc = "listacompaniidinsibiu2023martie";

            lfc.createFormular("AdaugareTari", new Form());
            lfc.listaFormularelor[0].formName.Show();
            lfc.listaFormularelor[0].formName.Name = "adaugatari";
            lfc.listaFormularelor[0].formName.Text = "adaugatari";
            lfc.listaFormularelor[0].createRecord("001", "Label", "lblnume", "Nume familie:", 100, 10, 30, 60, Color.White, Color.Black, this.Font, true);
            lfc.listaFormularelor[0].drawFormular();
            lfc.listaFormularelor[0].createRecord("002","TextBox","txtnume","Nume familie",100,50,30,100,Color.White,Color.Black,this.Font,true);
            lfc.listaFormularelor[0].drawFormular();
            lfc.listaFormularelor[0].createRecord("002", "Button", "btnAdauga", "Adauga", 100, 90, 30, 100, Color.White, Color.Black, this.Font, true);
            lfc.listaFormularelor[0].drawFormular();
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lfc.listaFormularelor[0].formName.Focus();
        }
    }
}

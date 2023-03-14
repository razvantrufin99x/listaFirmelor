using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaFirmelor
{
    public class formular
    {
        public string codformular;
        public List<recordControl> controlList = new List<recordControl>();
        public Form formName;

        public formular() { }

        public int getControlsNumberOnform(Form f)
        {
            return f.Controls.Count;
        }
        public void drawFormular()
        {
            int nrofcontrols;
            for(int i = 0; i < controlList.Count; i++)
            {
                if (controlList[i].tipcontrol == "TextBox")
                {
                    formName.Controls.Add(new TextBox());
                    nrofcontrols = this.getControlsNumberOnform(this.formName)-1;
                    formName.Controls[nrofcontrols].Name = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Text = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Left = controlList[i].left;
                    formName.Controls[nrofcontrols].Top = controlList[i].top;
                    formName.Controls[nrofcontrols].Height = controlList[i].height;
                    formName.Controls[nrofcontrols].Width = controlList[i].width;
                    formName.Controls[nrofcontrols].BackColor = controlList[i].background;
                    formName.Controls[nrofcontrols].ForeColor = controlList[i].foreground;
                    formName.Controls[nrofcontrols].Font = controlList[i].f;
                    formName.Controls[nrofcontrols].Visible = controlList[i].visible;
                    formName.Controls[nrofcontrols].Show();
                }
                else if (controlList[i].tipcontrol == "Label")
                {
                    formName.Controls.Add(new Label());
                    nrofcontrols = this.getControlsNumberOnform(this.formName) - 1;
                    formName.Controls[nrofcontrols].Name = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Text = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Left = controlList[i].left;
                    formName.Controls[nrofcontrols].Top = controlList[i].top;
                    formName.Controls[nrofcontrols].Height = controlList[i].height;
                    formName.Controls[nrofcontrols].Width = controlList[i].width;
                    formName.Controls[nrofcontrols].BackColor = controlList[i].background;
                    formName.Controls[nrofcontrols].ForeColor = controlList[i].foreground;
                    formName.Controls[nrofcontrols].Font = controlList[i].f;
                    formName.Controls[nrofcontrols].Visible = controlList[i].visible;
                    formName.Controls[nrofcontrols].Show();
                }
                else if (controlList[i].tipcontrol == "Button")
                {
                    formName.Controls.Add(new Button());
                    nrofcontrols = this.getControlsNumberOnform(this.formName) - 1;
                    formName.Controls[nrofcontrols].Name = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Text = controlList[i].denumire;
                    formName.Controls[nrofcontrols].Left = controlList[i].left;
                    formName.Controls[nrofcontrols].Top = controlList[i].top;
                    formName.Controls[nrofcontrols].Height = controlList[i].height;
                    formName.Controls[nrofcontrols].Width = controlList[i].width;
                    formName.Controls[nrofcontrols].BackColor = controlList[i].background;
                    formName.Controls[nrofcontrols].ForeColor = controlList[i].foreground;
                    formName.Controls[nrofcontrols].Font = controlList[i].f;
                    formName.Controls[nrofcontrols].Visible = controlList[i].visible;
                    formName.Controls[nrofcontrols].Show();
                }
            }
            
        }

        public void createRecord
           (
        string pcodrecord,
        string ptipcontrol,
        string pdenumire,
        string ptext,
        int pleft,
        int ptop,
        int pheight,
        int pwidth,
        Color pbackground,
        Color pforeground,
        Font pf,
        bool pvisible
           )
        {
            controlList.Add(new recordControl());
            controlList[controlList.Count - 1].codrecord = pcodrecord;
            controlList[controlList.Count - 1].tipcontrol = ptipcontrol;
            controlList[controlList.Count - 1].denumire = pdenumire;
            controlList[controlList.Count - 1].text = ptext;
            controlList[controlList.Count - 1].left = pleft;
            controlList[controlList.Count - 1].top = ptop;
            controlList[controlList.Count - 1].height = pheight;
            controlList[controlList.Count - 1].width = pwidth;
            controlList[controlList.Count - 1].background = pbackground;
            controlList[controlList.Count - 1].foreground = pforeground;
            controlList[controlList.Count - 1].f = pf;
            controlList[controlList.Count - 1].visible = pvisible;

        }
    }
}

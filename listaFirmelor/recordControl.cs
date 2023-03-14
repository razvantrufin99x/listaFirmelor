using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaFirmelor
{
    public class recordControl
    {
        public string codrecord;
        public string tipcontrol;
        public string denumire;
        public string text;
        public int left;
        public int top;
        public int height;
        public int width;
        public List<string> events = new List<string>();
        public Color background;
        public Color foreground;
        public Font f;
        public bool visible;
    }
}

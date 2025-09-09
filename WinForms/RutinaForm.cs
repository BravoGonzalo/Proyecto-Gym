using Proyecto_Gym.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gym.WinForms
{
    public partial class RutinaForm : Form
    {
        private Cliente c;

        public RutinaForm()
        {
            InitializeComponent();
        }

        public RutinaForm(Cliente c)
        {
            this.c = c;
        }
    }
}

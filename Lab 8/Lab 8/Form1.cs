using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        public Form1()
        {
            InitializeComponent();
            panels.Add("Tipo", panel1);
            panels.Add("Tienda", panel2);
            panels.Add("Restaurante", panel4);
            panels.Add("Cine", panel3);
            panels.Add("Recreacional", panel5);
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }
        private void comboBoxAgregarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxAgregarTipo.SelectedIndex == 0)
            {
                stackPanels.Add(panels["Tienda"]);
                ShowLastPanel();
            }
            else if (comboBoxAgregarTipo.SelectedIndex == 1)
            {
                stackPanels.Add(panels["Restaurante"]);
                ShowLastPanel();
            }
            else if (comboBoxAgregarTipo.SelectedIndex == 2)
            {
                stackPanels.Add(panels["Cine"]);
                ShowLastPanel();
            }
            else if (comboBoxAgregarTipo.SelectedIndex == 3)
            {
                stackPanels.Add(panels["Recreacional"]);
                ShowLastPanel();
            }
            else
            {
            }
        }

        private void buttonTVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }

        private void buttonCVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }

        private void buttonRestVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }

        private void buttonRecVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }
    }
}

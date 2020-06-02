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
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            panels.Add("Tipo", panel1);
            panels.Add("Tienda", panel2);
            panels.Add("Restaurante", panel4);
            panels.Add("Cine", panel3);
            panels.Add("Recreacional", panel5);
            panels.Add("VerInfo", panel6);
            panels.Add("Info", panel7);
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

        private void buttonTodLoc_Click(object sender, EventArgs e)
        {
            TodosLocales todosLocales = new TodosLocales(controller.locales);
            todosLocales.Show();
        }

        private void buttonLocalVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Tipo"]);
            ShowLastPanel();
        }

        private void buttonVerInfo_Click(object sender, EventArgs e)
        {
            foreach (Local j in controller.locales)
            {
                comboBoxVerInfo.Items.Add(j.Name);
            }
            stackPanels.Add(panels["VerInfo"]);
            ShowLastPanel();
        }

        private void buttonVerInfoLocal_Click(object sender, EventArgs e)
        {
            foreach (Local j in controller.locales)
            {
                if (comboBoxVerInfo.SelectedItem.ToString() == j.Name)
                {
                    labelLocal.Text = j.Name;
                    textBoxLocal.Text = j.Show();
                }
            }
            stackPanels.Add(panels["Info"]);
            ShowLastPanel();
        }

        private void buttonAgregarCine_Click(object sender, EventArgs e)
        {
            string name, name_Dueno, horario;
            int num;
            decimal salas;
            name = textBoxCName.Text;
            name_Dueno = textBoxCNameD.Text;
            horario = textBoxCHorario.Text;
            salas = numericUpDownCine.Value;

            try
            {
                num = Int32.Parse(textBoxCNum.Text);
                Cine cine = new Cine(name, name_Dueno, horario, num, salas);
                controller.locales.Add(cine);
                MessageBox.Show("Se ha agregado correctamente");
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
            catch
            {
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }

        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            string name, name_Dueno, horario;
            int num;
            bool mesas;
            name = textBoxRestName.Text;
            name_Dueno = textBoxREstNameD.Text;
            horario = textBoxRestHorario.Text;
            mesas = checkBoxRest.Checked;

            try
            {
                num = Int32.Parse(textBoxRestNum.Text);
                Restaurante restaurante = new Restaurante(name, name_Dueno, horario, num, mesas);
                controller.locales.Add(restaurante);
                MessageBox.Show("Se ha agregado correctamente");
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
            catch
            {
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
        }

        private void buttonRec_Click(object sender, EventArgs e)
        {
            string name, name_Dueno, horario;
            int num;
            name = textBoxRecName.Text;
            name_Dueno = textBoxRecNameD.Text;
            horario = textBoxRecHorario.Text;

            try
            {
                num = Int32.Parse(textBoxRecNum.Text);
                Recreacional recreacional = new Recreacional(name, name_Dueno, horario, num);
                controller.locales.Add(recreacional);
                MessageBox.Show("Se ha agregado correctamente");
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
            catch
            {
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            string name, name_Dueno, horario, cat;
            int num;
            List<string> categorias = new List<string>();
            name = textBoxTName.Text;
            name_Dueno = textBoxTNameD.Text;
            horario = textBoxTHorario.Text;
            cat = textBoxTCat.Text;
            int position = 0;
            int start = 0;
            do
            {
                position = cat.IndexOf(',', start);
                if (position >= 0)
                {
                    categorias.Add(cat.Substring(start, position - start + 1).Trim());
                    start = position + 1;
                }
            } while (position > 0);

            try
            {
                num = Int32.Parse(textBoxTNum.Text);
                Tienda tienda = new Tienda(name, name_Dueno, horario, num, categorias);
                controller.locales.Add(tienda);
                MessageBox.Show("Se ha agregado correctamente");
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
            catch
            {
                stackPanels.Add(panels["Tipo"]);
                ShowLastPanel();
            }
        }
    }
}

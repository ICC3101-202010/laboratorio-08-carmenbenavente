using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class TodosLocales : UserControl
    {
        public TodosLocales(List<Local> locales)
        {
            InitializeComponent();
            foreach (Local j in locales)
            {
                comboBoxTodosLocales.Items.Add(j.Name);
            }
        }

        private void comboBoxTodosLocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using ContainerSchip.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchip
{
    public partial class ContainerSchip : Form
    {
        Ship ship;

        List<Logic.Container> containers = new List<Logic.Container>();


        public ContainerSchip()
        {
            InitializeComponent();
        }


        private void btnAddContainer_Click(object sender, EventArgs e)
        {

            bool coolable = false;
            bool valuable = false;
            int weight = Convert.ToInt32(nupWeight.Value);
            


            if (cbCoolable.Checked)
            {
                coolable = true;
            }
            if (cbValuable.Checked)
            {
                valuable = true;
            }


            Logic.Container container = new Logic.Container(weight, valuable, coolable);

            for (int i = 0; i < nupAmount.Value; i++)
            {
                containers.Add(container);
                lbContainers.Items.Add(container);
            }

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
           ship = new Ship(Convert.ToInt32(nupLength.Value), 
                           Convert.ToInt32(nupWidth.Value), 
                           Convert.ToInt32(nupHeight.Value));

            lbContainers.Items.Clear();

            foreach (Logic.Container container in ship.DistributeContainers(containers))
            {
                lbContainers.Items.Add(container);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var editGameForm = new EditGames();
            editGameForm.Closed += (s, args) => Show();
            editGameForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            var findGameForm = new FindGames();
            findGameForm.Closed += (s, args) => Show();
            findGameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form gameSysForm = new gameSystems();
            //gameSysForm.ShowDialog();

            Hide();
            var gameSysForm = new gameSystems();
            gameSysForm.Closed += (s, args) => Show();
            gameSysForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

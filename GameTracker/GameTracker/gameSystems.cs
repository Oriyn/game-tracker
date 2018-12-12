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
    public partial class gameSystems : Form
    {
        public gameSystems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new GameTrackerDBmodel())
            {
                try
                {
                    var system = new SYSTEM
                    {
                        SYSTEMNAME = sysNameTxt.Text,
                        SYSTEMRELEASE = Convert.ToDateTime(sysPubTxt.Text),
                        SYSMANUFACTURE = sysMenuTxt.Text
                    };
                    db.SYSTEMS.Add(system);
                    db.SaveChanges();
                    MessageBox.Show("Your game has been added to the database", "Added Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sysNameTxt.Clear();
                    sysMenuTxt.Clear();
                    sysPubTxt.Clear();
                    var query = (from b in db.SYSTEMS
                                 orderby b.SYSTEMNAME
                                 select b).ToList();
                    dataGridView1.DataSource = query;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAllSysBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string ouputString = "";
            using (var db = new GameTrackerDBmodel())
            {
                var query = from b in db.SYSTEMS
                            orderby b.SYSTEMNAME
                            select b;

                foreach (var item in query)
                {
                    ouputString += "System ID: " + item.SYSID + Environment.NewLine 
                        + "System Name:  " + item.SYSTEMNAME + Environment.NewLine
                        + "System Release Date: " + item.SYSTEMRELEASE + Environment.NewLine 
                        + "System Manufacturer: " + item.SYSMANUFACTURE +
                        Environment.NewLine + Environment.NewLine;
                }
                richTextBox1.Text = ouputString;
            }
        }
    }
}

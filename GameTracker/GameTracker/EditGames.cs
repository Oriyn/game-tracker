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
    public partial class EditGames : Form
    {
        public EditGames()
        {
            InitializeComponent();
            using (var db = new GameTrackerDBmodel()) {
                var query = (from b in db.GAMES
                            orderby b.GAMENAME
                            select b).ToList();
                dataGridView1.DataSource = query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = new GameTrackerDBmodel())
            {
                try
                {
                    var game = new GAME
                    {
                        GENREID = Convert.ToInt32(genreTxt.Text),
                        GAMENAME = nameTxt.Text,
                        PUBLISHDATE = Convert.ToDateTime(publishTxt.Text),
                        GAMEDESC = descTxt.Text 
                    };
                    db.GAMES.Add(game);
                    db.SaveChanges();
                    MessageBox.Show("Your game has been added to the database", "Added Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    genreTxt.Clear();
                    nameTxt.Clear();
                    publishTxt.Clear();
                    descTxt.Clear();
                    var query = (from b in db.GAMES
                                 orderby b.GAMENAME
                                 select b).ToList();
                    dataGridView1.DataSource = query;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new GameTrackerDBmodel())
            {

            }
        }
    }
}

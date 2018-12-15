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
    public partial class FindGames : Form
    {
        public FindGames()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string ouputString = "";
            using (var db = new GameTrackerDBmodel()) {
                var query = from b in db.GAMES
                            orderby b.GAMENAME
                            select b;

                foreach (var item in query)
                {
                    ouputString += "Game ID: " + item.GAMEID + " , Genre ID: " + item.GENREID + " , " 
                        + item.GAMENAME + " , " + item.PUBLISHDATE + " , " + item.GAMEDESC +
                        Environment.NewLine + Environment.NewLine;
                }
                richTextBox1.Text = ouputString;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string ouputString = "";
            string gameInput = gameInputTxt.Text;
            using (var db = new GameTrackerDBmodel())
            {
                var query = from b in db.GAMES
                            where b.GAMENAME.Contains(gameInput) 
                            orderby b.GAMENAME
                            select b;

                foreach (var item in query)
                {
                    ouputString += "Game ID: " + item.GAMEID + " , Genre ID: " + item.GENREID + " , "
                        + item.GAMENAME + " , " + item.PUBLISHDATE + " , " + item.GAMEDESC +
                        Environment.NewLine + Environment.NewLine;
                }
                richTextBox1.Text = ouputString;
            }

        }
    }
}

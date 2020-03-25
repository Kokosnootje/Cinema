using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Project_B___Cinema
{
    public partial class MainMenu : Form
    {        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var jsonResponse = "[" +
                "{'Id':'2','Title':'Blade','Genre':[{'id':'1','name':'Action'}]}," +
                "{'Id':'3','Title':'Aladdin','Genre':[{'id':'2','name':'Fantasy'}]}," +
                "{'Id':'4','Title':'Lord of the Rings','Genre':[{'id':'2','name':'Fantasy'}]}]";
            //var jsonlist = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnackPage sp = new SnackPage();
            sp.ShowDialog();
        }

        private void contactToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContactPage cp = new ContactPage();
            cp.ShowDialog();
        }
    }
}

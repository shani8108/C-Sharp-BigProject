using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowBigProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTupple_Click(object sender, EventArgs e)
        {
            Meet1_Tuple meet1_Tuple = new Meet1_Tuple();
            meet1_Tuple.Run();
        }
    }
}

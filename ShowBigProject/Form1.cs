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

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            Meet1_Delegate meet1_Delegate = new Meet1_Delegate();
            meet1_Delegate.Run();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Meet1_Events meet1_Events = new Meet1_Events();
            Operate operate = new Operate();
            operate.Init();
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            Meet2_Foreach meet2_Foreach = new Meet2_Foreach();
            meet2_Foreach.RunMyItems();
        }

        private void btnStackHeap_Click(object sender, EventArgs e)
        {
            Meet3_StackHeap meet3_StackHeap = new Meet3_StackHeap();
            meet3_StackHeap.Run();
        }

        private void btnRefVal_Click(object sender, EventArgs e)
        {
            Meet3_RefVal meet3_RefVal = new Meet3_RefVal(); 
            meet3_RefVal.Run();
        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            Meet3_Nullable  meet3_Nullable = new Meet3_Nullable();
            meet3_Nullable.Run();
                    
        }
    }
}

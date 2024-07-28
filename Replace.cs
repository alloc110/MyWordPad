using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }
        public delegate void GETDATA(string data);
        public GETDATA data;
        public GETDATA data_find;
        public GETDATA data_set;
        public bool get_data_set(bool data)
        {
            return data;
        }
        
        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Find_Next_Click(object sender, EventArgs e)
        {
            //data(text_find.Text);
            data_set("0");
        }

        private void but_Rep_Click(object sender, EventArgs e)
        {
            data(text_find.Text);
            data_find(txt_replace.Text);
            data_set("1"); 
        }

        private void but_repAll_Click(object sender, EventArgs e)
        {
            data(text_find.Text);
            data_find(txt_replace.Text);
            data_set("2"); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRAS
{
    public partial class UserGuide : Form
    {
        formRRAS _main;
        public UserGuide(formRRAS main)
        {
            InitializeComponent();
            _main = main;
        }

        private void UserGuide_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

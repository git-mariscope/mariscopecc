using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testform.models;
namespace testform
{
    public partial class fCam1 : Form
    {
        camera c = new camera();
        public fCam1()
        {
            InitializeComponent();
            c.ip_server = "http://192.168.2.251";
        }
        
        private void btnTest_Click(object sender, EventArgs e)
        {
           
        }
    }
}

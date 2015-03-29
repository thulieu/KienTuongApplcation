using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DRBISPKT.Form_View;

namespace DRBISPKT
{
    public partial class DRBISPKT : DevExpress.XtraEditors.XtraForm
    {
        public bool show_map_controler=false;
       public MapControler map_controler= new MapControler();
        
        public DRBISPKT()
        {
            InitializeComponent();

        }

        private void barCheckItem6_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Bảng thông tin click
        }

        private void barCheckItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // show or hidden maps controller
           
          if (show_map_controler == false) 
            {
                map_controler.StartPosition = FormStartPosition.Manual;
                map_controler.Location = new Point(5, 190);
                map_controler.Show();
                show_map_controler = true;
          } 
          else { map_controler.Hide();
                show_map_controler = false;

          }
         
        }
    }
}

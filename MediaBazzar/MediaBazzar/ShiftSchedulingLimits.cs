using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public partial class ShiftSchedulingLimits : Form
    {
        ShiftLimitManager Limits;
        List<NumericUpDown> textboxes;
        public ShiftSchedulingLimits()
        {
            InitializeComponent();
            Limits = new ShiftLimitManager();


            textboxes = new List<NumericUpDown>()
            {
                numericUpDown1,
                numericUpDown2,
                numericUpDown3,
                nd4,
                nd5,
                nd6,
                nd7,
                nd8,
                nd9,
                nd10,
                nd11,
                nd12,
                nd13,
                nd14,
                nd15,
                nd16,
                nd17,
                nd18,
                nd19,
                nd20,
                nd21,
            };

       

            for (int i = 0; i < Limits.GetLimits().Count; i++)
            {
               textboxes[i].Value = Limits.GetLimits()[i];
            }

      



        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<decimal> temp = new List<decimal>();

            for (int i = 0; i < textboxes.Count; i++)
            {
                temp.Add(textboxes[i].Value);
            }
            Limits.UpdateLimits(temp);
            MessageBox.Show("Limits updated");
        }
    }
}

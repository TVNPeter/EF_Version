using EF_Version.BLL;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EF_Version.UI.Usercontrol
{
    public partial class uc_DashBoard : UserControl
    {
        BLLDoctor bllDoctor = new BLLDoctor();
        public uc_DashBoard()
        {
            InitializeComponent();
        }
        public uc_DashBoard(string role, int userid)
        {
            InitializeComponent();
            lbl_Role.Text = role;
            if (role == "Doctor")
            {
                var person = bllDoctor.GetById(userid, out string err);
                lbl_ID.Text = person.DoctorID.ToString();
                lbl_Name.Text = person.FullName;
                lbl_Phone.Text = person.Phone;
                lbl_Specialty.Text = person.Specialty; 
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Doctor", userid + ".png"); 
                if (File.Exists(imagePath))
                {
                    pb_Avatar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pb_Avatar.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "default.jpg"));
                }
            }
            else if (role == "Admin")
            {

                lbl_S.Visible = false;
                lbl_Specialty.Visible = false;
            }
            else if (role == "Secretary")
            {

                lbl_S.Visible = false;
                lbl_Specialty.Visible = false;
            }
        }
    }
}

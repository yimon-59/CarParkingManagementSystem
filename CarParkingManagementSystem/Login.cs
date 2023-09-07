using CarParkingManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class Login : Form
    {
        CarParkingManagementSystemEntities dataEntities = new CarParkingManagementSystemEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    var item = dataEntities.Users.Where(u => u.UserName == txtUserName.Text
                                                        && u.Password == txtPassword.Text).FirstOrDefault();
                    if(item != null)
                    {
                        Menu menuForm = new Menu();
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Authentication Fail!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

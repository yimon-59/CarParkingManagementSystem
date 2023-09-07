using CarParkingManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class ParkingList : Form
    {
        List<CarInfo> carInfoList = new List<CarInfo>();
        CarParkingManagementSystemEntities systemEntities = new CarParkingManagementSystemEntities();
        public ParkingList()
        {
            InitializeComponent();
        }

        private void ParkingList_Load(object sender, EventArgs e)
        {
            GetParkingList();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var result = systemEntities.CarInfoes.Where(c => c.PlateNumber == txtCarNumber.Text).FirstOrDefault();
            if(result != null)
            {
                if (result.TimeOut == null)
                {
                    MessageBox.Show("This car is already parking in.");
                    return;
                }
            }
            if (Validation())
            {
                if (!string.IsNullOrEmpty(txtCarNumber.Text))
                {
                    CarInfo carDetail = new CarInfo();
                    carDetail.PlateNumber = txtCarNumber.Text;
                    carDetail.TimeIn = DateTime.Now;
                    carDetail.ShopName = txtShopName.Text;
                    systemEntities.CarInfoes.Add(carDetail);
                    systemEntities.SaveChanges();
                    GetParkingList();
                }
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtCarNumber.Text))
            {
                MessageBox.Show("Please enter Car Plate Number.");
                return false;
            }
            if (string.IsNullOrEmpty(txtShopName.Text))
            {
                MessageBox.Show("Please enter Shop Name.");
                return false;
            }
            return true;
        }

        private void GetParkingList()
        {
            carInfoList = systemEntities.CarInfoes.ToList();
            dgList.DataSource = carInfoList;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int isUsedReceipt = 0;
            var result = systemEntities.CarInfoes.Where(c => c.PlateNumber == txtCarNumber.Text).FirstOrDefault();
            if (result == null)
            {
                    MessageBox.Show("Please Park In First.");
                    return;
            }
            if (Validation())
            {
                var fees = 0.0;
                var diffMin = DateTime.Now.Subtract(result.TimeIn).TotalMinutes;
                DialogResult dialogResult = MessageBox.Show("Will you use shopping receipt?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (result.IsReciptUsed == 1)
                    {
                        MessageBox.Show("This shopping receipt is already used with this car.");
                        return;
                    }
                    if (diffMin > 60)
                    {
                        var time = diffMin - 60;
                        fees = time / 60 * 1000;
                        isUsedReceipt = 1;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    fees = diffMin / 60 * 1000;
                }

                var carList = (from p in systemEntities.CarInfoes
                               where p.PlateNumber == txtCarNumber.Text && p.Id != p.Id
                               select p).ToList();

                foreach (var car in carList)
                {
                    car.Cost = Math.Round(Convert.ToDecimal(fees));
                    car.TimeOut = DateTime.Now;
                    car.IsReciptUsed = isUsedReceipt;
                }
                systemEntities.SaveChanges();

                GetParkingList();
            }
        }

    }
}

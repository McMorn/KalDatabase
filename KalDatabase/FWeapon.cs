using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalDatabase
{
    public partial class FWeapon : Form
    {
        private DBConnect database;

        public FWeapon()
        {
            InitializeComponent();
            database = new DBConnect();
        }

        protected override void OnLoad(EventArgs e)
        {
            database.OpenConnection();
            try
            {
                cb_Class.DataSource = database.Select(
                        "Class",
                        true,
                        "KalClass",
                        "")[0];
                cb_Grade.DataSource = database.Select(
                        "Grade",
                        true,
                        "KalWeapons w, KalClass c",
                        "w.idClass=c.idClass and c.Class=\'" + cb_Class.SelectedItem.ToString() + "\'")[0];
                cb_Name.DataSource = database.Select(
                        "Name",
                        false,
                        "KalWeapons w, KalClass c",
                        "w.idClass=c.idClass and w.Grade=\'" + cb_Grade.SelectedItem.ToString() + "\' and c.Class=\'" + cb_Class.SelectedItem.ToString() + "\'")[0];

                Update();
            }
            catch (NullReferenceException) { }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseConnection();
            database = null;
        }

        private new void Update()
        {
            try
            {
                List<string>[] list = database.Select(
                        "ReqLvl, PA_min, PA_max",
                        false,
                        "KalWeapons",
                        "Name=\'" + cb_Name.SelectedItem.ToString() + "\'");

                tb_Reqlvl.Text = list[0][0].ToString();
            }
            catch (NullReferenceException) { }
        }
    }
}

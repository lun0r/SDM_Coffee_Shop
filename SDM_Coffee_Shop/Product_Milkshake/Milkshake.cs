﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Milkshake : Beverage
    {
        public bool HasDairy { get; set; }
        public bool HasWhippedCream { get; set; }

        public Milkshake()
        {
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasDairy = new CheckBox();
            CHasDairy.Text = "Dairy";
            CHasDairy.Checked = true;
            CHasDairy.Name = "CHasDairy";
            CHasDairy.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasDairy);

            CheckBox CHasWhippedCream = new CheckBox();
            CHasWhippedCream.Text = "Whipped Cream";
            CHasWhippedCream.Name = "CHasWhippedCream";
            CHasWhippedCream.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasWhippedCream);

            return TempList;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            var x = sender as Control;
            switch (x.Name)
            {
                case "CHasDairy":
                    HasDairy = ((CheckBox)x).Checked;
                    break;

                case "CHasWhippedCream":
                    HasWhippedCream = ((CheckBox)x).Checked;
                    break;
            }
        }

        public override string ToString()
        {
            return $"Dairy:{(HasDairy ? "Yes" : "No")},Whipped Cream: {(HasWhippedCream ? "Yes" : "No")}";
        }
    }
}
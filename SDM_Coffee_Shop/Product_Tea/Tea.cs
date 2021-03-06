﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Tea : Beverage
    {
        public typeOfTheine Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Tea()
        {
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasMilk = new CheckBox();
            CHasMilk.Text = "Milk";
            CHasMilk.Name = "CHasMilk";
            CHasMilk.Checked = false;
            HasMilk = CHasMilk.Checked;
            CHasMilk.CheckedChanged += new System.EventHandler(this.SetControls);

            TempList.Add(CHasMilk);

            CheckBox CHasSugar = new CheckBox();
            CHasSugar.Text = "Sugar";
            CHasSugar.Name = "CHasSugar";
            CHasSugar.Checked = false;
            HasSugar = CHasSugar.Checked;
            CHasSugar.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasSugar);

            ComboBox CTheine = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(typeOfCaffeine)))
            {
                CTheine.Items.Add(item + " Theine");
            }
            CTheine.SelectedIndex = 1;
            Theine = (typeOfTheine)CTheine.SelectedIndex;
            CTheine.Name = "CTheine";
            CTheine.TextChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CTheine);

            return TempList;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            var Michiel = sender as Control;
            switch (Michiel.Name)
            {
                case "CHasMilk":
                    HasMilk = ((CheckBox)Michiel).Checked;
                    break;

                case "CHasSugar":
                    HasSugar = ((CheckBox)Michiel).Checked;
                    break;

                case "CTheine":
                    Theine = (typeOfTheine)((ComboBox)Michiel).SelectedIndex;
                    break;
            }
        }

        public override string ToString()
        {
            return $"Theine: {Theine},Milk:{(HasMilk ? "Yes" : "No")},Sugar: {(HasSugar ? "Yes" : "No")}";
        }
    }
}
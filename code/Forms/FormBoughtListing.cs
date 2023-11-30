﻿using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormBoughtListing : Form
    {
        private string saveAdress;
        public FormBoughtListing(Advertisement listing)
        {
            InitializeComponent();

            try
            {
                this.Text = listing.Name;
                lblName.Text = listing.Name;
                lblSeller.Text = $"Куплено від: {listing.Seller}";
                string truncatedDescription = listing.Description.Length > 60 ? listing.Description.Substring(0, 57) + "..." : listing.Description;
                this.lblDescription.Text = truncatedDescription;
                this.toolTipDescription.SetToolTip(this.lblDescription, listing.Description);
                lblAddress.Text = this.lblAddress.Text = $"{listing.Address} (натисніть щоб перейти на мапу)";
                saveAdress = listing.Address;
                lblPrice.Text = $"${listing.Price} або {listing.Price * Classes.СurrencyСonverter.GetDollarRate()} ₴";
                lblOwner.Text = $"Власник: {LoginManager.CurrentUser.Name}";
                pictureBoxListingImage.Image = Image.FromFile(listing.ImagePath);
                }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити деталі оголошення. Спробуйте пізніше", "Помилка завантаження даних");
            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            Classes.ShowMap.GoToMap(saveAdress);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraSinav
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


    /* ----- CUSTOM FUNCTIONS ----- */

        /* ----- Product Search Function ----- */
        private Boolean searchProduct(string nameProduct)
        {
            /* ----- Returns TRUE if the product that user looking for exist in checkedListBoxProduct ----- */

            /* ----- Variables ----- */
            Boolean resultCheck = false;

            if (checkedListBoxProduct.Items.Contains(textBoxProduct.Text))
            {
                resultCheck = true;
            }

            return resultCheck;
        }

        /* ----- Total Price Function ----- */
        private void priceTotal()
        {
            string priceString;

            int indexOfItem = 0;
            double priceDouble = 0;
            double priceTotal = 0;

            while (indexOfItem < listBoxPrice.Items.Count)
            {
                priceString = listBoxPrice.Items[indexOfItem].ToString();
                priceDouble = double.Parse(priceString);

                priceTotal = priceTotal + priceDouble;

                indexOfItem++;
            }

            labelTotal.Text = priceTotal.ToString() + " TL";
        }


    /* ------ BUTTONS ----- */

        /* ------ Add Button ------ */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /* ----- Checking that input type is double ----- */
                double controlPrice = double.Parse(textBoxPrice.Text); // Price input must be double.

                /* ----- Adding inputs from textBoxes to checkedLists ----- */
                if (!searchProduct(textBoxProduct.Text)) // A product cannot be added for more than one time.
                {
                    checkedListBoxProduct.Items.Add(textBoxProduct.Text); // Add product name from textBoxProduct to checkedListBoxProduct
                    checkedListBoxPrice.Items.Add(textBoxPrice.Text); // Add price value from textBoxPrice to checkedListBoxPrice
                }
                else
                {
                    MessageBox.Show("'" + textBoxProduct.Text + "'" + " isimli ürün zaten var.", "Bir sorun ile karşılaşıldı...");
                }
            }

            catch
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin.", "Bir sorun ile karşılaşıldı...");
            }
        }

        /* ----- Delete Button ----- */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int indexOfItem = 0;

            if (checkedListBoxPrice.CheckedItems.Count < 1)
            {
                MessageBox.Show("Öncelikle seçim yapmalısınız.");
            }

            while (indexOfItem < checkedListBoxProduct.Items.Count)
            {
                if (checkedListBoxProduct.GetItemChecked(indexOfItem))
                {
                    /* ----- Remove items at listBoxes*/
                    listBoxProduct.Items.RemoveAt(listBoxProduct.Items.IndexOf(checkedListBoxProduct.Items[indexOfItem]));
                    listBoxPrice.Items.RemoveAt(listBoxPrice.Items.IndexOf(checkedListBoxPrice.Items[indexOfItem]));

                    /* ----- Calculate total price ----- */
                    priceTotal();

                    /* ----- Remove items at checkedListBoxes ----- */
                    checkedListBoxProduct.Items.RemoveAt(indexOfItem);
                    checkedListBoxPrice.Items.RemoveAt(indexOfItem);
                }

                indexOfItem++;

            }
        }

        /* ----- Clear Label ----- */
        private void linkLabelClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxProduct.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
        }

        /* ----- Close Button ----- */
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İyi günler, hoşçakalın...", "Çıkış Yapılıyor...");
            Close();
        }


    /* ----- CHECKED LIST BOXES ----- */

        /* ----- Product List ----- */
        private void checkedListBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfCheckedListBox = checkedListBoxProduct.SelectedIndex;
            int indexOftextListBox;
            
            if (indexOfCheckedListBox < 0) { return; } // index cannot be < 0

            /* ----- Check items ----- */
            checkedListBoxPrice.SelectedIndex = indexOfCheckedListBox;
            checkedListBoxPrice.SetItemChecked(indexOfCheckedListBox, checkedListBoxProduct.GetItemChecked(indexOfCheckedListBox));

            /* ---- Search item in listBox ----- */
            indexOftextListBox = listBoxProduct.Items.IndexOf(checkedListBoxProduct.Items[indexOfCheckedListBox]);

            if (indexOftextListBox < 0 && checkedListBoxProduct.GetItemChecked(indexOfCheckedListBox)) //if it does not exist and selected
            {
                /* ----- Add to listBoxes ----- */
                listBoxProduct.Items.Add(checkedListBoxProduct.Items[indexOfCheckedListBox]);                   
                listBoxPrice.Items.Add(checkedListBoxPrice.Items[indexOfCheckedListBox]);
            }

            if (indexOftextListBox >= 0 && !checkedListBoxProduct.GetItemChecked(indexOfCheckedListBox)) //if it exists and not selected
            {
                /* ----- remove from listBoxes ----- */
                listBoxProduct.Items.RemoveAt(indexOftextListBox);
                listBoxPrice.Items.RemoveAt(indexOftextListBox);
            }

            /* ----- Calculate total price ----- */
            priceTotal();
        }

        /* ----- Price List ----- */
        private void checkedListBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfCheckedListBox = checkedListBoxPrice.SelectedIndex;
            int indexOfListBox;

            if (indexOfCheckedListBox < 0) { return; } // index cannot be < 0

            /* ----- Check items ----- */
            checkedListBoxProduct.SelectedIndex = indexOfCheckedListBox;
            checkedListBoxProduct.SetItemChecked(indexOfCheckedListBox, checkedListBoxPrice.GetItemChecked(indexOfCheckedListBox));

            /* ---- Search item in listBox ----- */
            indexOfListBox = listBoxPrice.Items.IndexOf(checkedListBoxPrice.Items[indexOfCheckedListBox]);

            if (indexOfListBox < 0 && checkedListBoxPrice.GetItemChecked(indexOfCheckedListBox)) //if it does not exist and selected
            {
                /* ----- Add to listBoxes ----- */
                listBoxPrice.Items.Add(checkedListBoxPrice.Items[indexOfCheckedListBox]);
                listBoxProduct.Items.Add(checkedListBoxProduct.Items[indexOfCheckedListBox]);
            }

            if (indexOfListBox >= 0 && !checkedListBoxPrice.GetItemChecked(indexOfCheckedListBox)) //if it exists and not selected
            {
                /* ----- remove from listBoxes ----- */
                listBoxPrice.Items.RemoveAt(indexOfListBox);
                listBoxProduct.Items.RemoveAt(indexOfListBox);
            }

            /* ----- Calculate total price ----- */
            priceTotal();
        }
    
    }
}
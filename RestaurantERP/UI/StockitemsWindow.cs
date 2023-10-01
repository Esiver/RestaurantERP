using RestaurantERP.Classes;
using RestaurantERP.Classes.mtmRelations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantERP.UI
{
    public partial class StockitemsWindow : Form
    {
        public StockitemsWindow()
        {
            InitializeComponent();

            allStockitemsList.Items.Clear();
            allStockitemsList.DataSource = Helpers.dbStockitemQueries.GetAllStockItems();
            allStockitemsList.DisplayMember = "Title";

            // stockpiles-picker
            List<Stockpile> stockpiles = Helpers.dbStockpileQueries.GetAllStockpiles();
            comboBoxStockpile.DataSource = stockpiles;
            comboBoxStockpile.DisplayMember = "Title";
            comboBoxStockpile.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StockitemsWindow_Load(object sender, EventArgs e)
        {

        }
        private void addStockItemButton_Click(object sender, EventArgs e)
        {
            string inputSku = textBoxSku.Text;
            string inputTitle = textBoxTitle.Text;
            string inputDescription = textBoxDescription.Text;
            string inputOrigin = textBoxOrigin.Text;
            string inputPlacement = textBoxPlacement.Text;
            decimal inputBuyprice;
            int inputVolume;
            int inputSizeGram;
            DateTime inputOriginDate;
            DateTime inputLastChange = DateTime.Now;
            DateTime inputExpirationDate;
            Stockpile? inputStockpile;


            if (decimal.TryParse(textBoxBuyprice.Text, out inputBuyprice)) { }
            else
            {
                inputBuyprice = 0;
            }
            if (int.TryParse(textBoxVolume.Text, out inputVolume)) { }
            else
            {
                inputVolume = 0;
            }
            if (int.TryParse(textBoxSize.Text, out inputSizeGram)) { }
            else
            {
                inputSizeGram = 0;
            }

            if (DateTime.TryParse(dateBoxOrigin.Text, out inputOriginDate)) { }
            else
            {
                inputOriginDate = DateTime.Now;
            }
            if (DateTime.TryParse(dateBoxExpire.Text, out inputExpirationDate)) { }
            else
            {
                inputExpirationDate = DateTime.Now;
            }


            if (comboBoxStockpile.SelectedItem != null)
            {
                inputStockpile = comboBoxStockpile.SelectedValue as Stockpile;
            } else
            {
                inputStockpile = null;
            }

            StockItem newStockitem = new StockItem(0, inputSku, inputTitle, inputDescription, inputOrigin, inputBuyprice, inputVolume, inputSizeGram, inputPlacement, inputOriginDate, inputLastChange, inputExpirationDate);
            int stockitemId = Helpers.dbStockitemQueries.AddStockitem(newStockitem);
            if(inputStockpile != null)
            {
                //make relation
                int stockpileId = inputStockpile.Id;
                StockitemStockpileRelation stockitemStockpileRelation = new StockitemStockpileRelation(stockitemId,stockpileId);
                int mtmId = Helpers.dbMTMQueries.AddStockitemStockpileRelation(stockitemStockpileRelation);
                stockitemStockpileRelation.Id = mtmId;
            }

            //allStockitemsList.Items.Clear();
            allStockitemsList.Refresh();
            //allStockitemsList.DataSource = Helpers.dbStockitemQueries.GetAllStockItems();



        }

    }
}

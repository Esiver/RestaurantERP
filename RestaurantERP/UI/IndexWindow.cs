using RestaurantERP.Classes;
using RestaurantERP.UIFunctions;

namespace RestaurantERP
{
    public partial class IndexWindow : Form
    {
        public IndexWindow()
        {

            InitializeComponent();



            List<Store> allStores = Helpers.dbHelpers.GetAllStores();
            Store storeOne = allStores.FirstOrDefault();

            List<Stockpile> allStockpiles = Helpers.dbStockpileQueries.GetAllStockpiles();

            List<StoreProduct> storeOneProducts = Helpers.dbProductQueries.GetStoreProducts(storeOne);

            Console.WriteLine($"{storeOne.Title} has following ({storeOneProducts.Count()}) products: {storeOneProducts.FirstOrDefault().Title}");


            // //  init!
            // store
            Store loadedStore = storeOne;
            storeTitleLabel.Text = loadedStore.Title;

            // products
            List<StoreProduct> loadedStoreProducts = Helpers.dbProductQueries.GetStoreProducts(loadedStore);
            List<int> loadedStoreProductInts = Helpers.ObjectHelpers.GetProductIds(loadedStoreProducts);
            storeProductsListBox.DisplayMember = "Title";
            storeProductsListBox.DataSource = loadedStoreProducts;

            // stock items 
            List<StockItem> requiredStockItems = Helpers.dbStockitemQueries.GetProductRequiredStockitems(loadedStoreProducts);
            storeRequiredStockitemsListBox.DisplayMember = "Title";
            storeRequiredStockitemsListBox.DataSource = requiredStockItems;

        }

        private void OpenSalesButton_Click(object sender, EventArgs e)
        {
            UIFunctions.WindowHandlers.openSalesWindow();
        }
        private void OpenStockpilesButton_Click(object sender, EventArgs e)
        {
            UIFunctions.WindowHandlers.openStockitemsWindow();
        }

        private void storeProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
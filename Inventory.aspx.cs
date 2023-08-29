using InventoryData_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryGui
{
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliers = SupplierManager.GetSuppliers();
            gvInventory.DataSource = suppliers;
        }
    }
}
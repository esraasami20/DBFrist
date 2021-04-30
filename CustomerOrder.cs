using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFrist
{
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }
        public CustomerOrder(string _cusName)
        {
            InitializeComponent();
            CusName.Text = _cusName;
            CusOrder.DataSource = db.Customers
                                    .Single(c => c.CustomerID == _cusName)
                                    .Orders.Select(c => new { c.OrderID ,c.Customer.ContactName,
                                     c.RequiredDate
                                     }).ToList();

        }
        NORTHWNDEntities db = new NORTHWNDEntities();

    }
}

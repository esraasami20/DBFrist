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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCus.DataSource = db.Customers.Select(c => c.CustomerID ).ToList();
            listBoxpro.DataSource = db.Products.Select(c =>  c.ProductName ).ToList();
            emps.DataSource = db.Employees
                                .Select(emps => new {FullName= emps.FirstName + " " + emps.LastName , emps.EmployeeID})
                                .ToList();
            emps.DisplayMember = "FullName";           
            emps.ValueMember = "EmployeeID";
            
        }

        private void listBoxCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lboxcustomer
            numOfOrder.Text = db.Customers
                                .Single(c => c.CustomerID == listBoxCus.SelectedValue.ToString())
                                .Orders.Count.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerOrder customerOrder = new CustomerOrder(listBoxCus.SelectedValue.ToString());
            customerOrder.ShowDialog();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeData employee = new EmployeeData(int.Parse(emps.SelectedValue.ToString()));
            employee.ShowDialog();
        }

        private void listBoxpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var targetProduct = db.Products
                                  .Single(a => a.ProductName == listBoxpro.SelectedValue.ToString());
            unitPrice.Text = targetProduct.UnitPrice.ToString();
            Quntity.Text = targetProduct.QuantityPerUnit.ToString();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            var targetCustomer = listBoxCus.SelectedValue.ToString();
            var targetemployee =int.Parse(emps.SelectedValue.ToString());
            Order newOrder = new Order()
            {
                CustomerID = targetCustomer,
                EmployeeID= targetemployee,
                OrderDate = monthCalendar1.SelectionRange.Start,
                RequiredDate= monthCalendar1.SelectionRange.Start

            };
            db.Orders.Add(newOrder);
            var done =db.SaveChanges();
            if (done > 0)
            {
                MessageBox.Show("^_^ You Successfully added new Order ^_^");
                listBoxCus_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("^_^ Sorry You Failed to add new Order ^_^");
            }
        }

        private void addDetail_Click(object sender, EventArgs e)
        {
            //for any order ?=> last order for last customer, get order id
            //add order details(order id)
            var lastOrderIDForCurrentCustomer = db.Customers
                                                   .Single(a=>a.CustomerID==listBoxCus.SelectedValue.ToString())
                                                   .Orders.LastOrDefault().OrderID;
            Order_Detail order_Detail = new Order_Detail()
            {
                OrderID = lastOrderIDForCurrentCustomer,
                ProductID = db.Products.Single(c => c.ProductName == listBoxpro.SelectedValue.ToString())
                .ProductID,
                UnitPrice =decimal.Parse(unitPrice.Text),
                Quantity = short.Parse(Quntity.Text)
            };
            db.Order_Details.Add(order_Detail);
            var done = db.SaveChanges();
            if (done > 0)
            {
                MessageBox.Show("^_^ You Successfully added Details to the last Order ^_^");
                listBoxCus_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("^_^ Sorry You Failed to add Details to the last Order ^_^");
            }

        }
    }
}

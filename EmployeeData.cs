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
    public partial class EmployeeData : Form
    {
        public EmployeeData()
        {
            InitializeComponent();
        }
        public EmployeeData( int _empid)
        {
            InitializeComponent();
            CusName.Text = db.Employees.Single(a => a.EmployeeID == _empid).FirstName.ToString();
            title.Text = db.Employees.Single(a => a.EmployeeID == _empid).Title.ToString();
            date.Text = db.Employees.Single(a => a.EmployeeID == _empid).HireDate.ToString();
            region.Text = db.Employees.Single(a => a.EmployeeID == _empid).Region.ToString();
            postalcode.Text = db.Employees.Single(a => a.EmployeeID == _empid).PostalCode.ToString();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        
    }
}

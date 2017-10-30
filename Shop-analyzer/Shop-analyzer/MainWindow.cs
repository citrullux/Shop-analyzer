using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Indicators;

namespace Shop_analyzer
{
    public partial class MainWindow : Form
    {
        private BindingList<UserIndicators> Users;
        private BindingList<OrderIndicators> Orders;
        private BindingList<SignIndicators> Sign;

        private AddUser add_user;
        private AddOrder add_order;
        private AddEcon add_econ;

        public MainWindow()
        {
            InitializeComponent();
            add_user = new AddUser();
            Users = new BindingList<UserIndicators>();
            //привязка, няяя.
            dataUsers.DataSource = Users;
        }
    }
}

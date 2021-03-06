﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Indicators;
using ZedGraph;

namespace Shop_analyzer
{
    public partial class MainWindow : Form
    {
        private BindingList<UserIndicators> Users;
        private BindingList<OrderIndicators> Orders;
        private BindingList<EconIndicators> Econs;

        private AddUser add_user;
        private AddOrder add_order;
        private AddEcon add_econ;

        public MainWindow()
        {
            InitializeComponent();
            
            // открытие окон
            add_user = new AddUser();
            add_order = new AddOrder();
            add_econ = new AddEcon();

            Users = new BindingList<UserIndicators>();
            Orders = new BindingList<OrderIndicators>();
            Econs = new BindingList<EconIndicators>();

            //привязка Grid Driving Development
            dataUsers.DataSource = Users;
            dataOrders.DataSource = Orders;
            dataEcons.DataSource = Econs;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //var ind = dataUsers.CurrentRow.Index;
            //add_dialog.add = false;
            add_user.ShowDialog();
            if (add_user.save)
            {
                Users.Add(add_user.User);
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            {
                // А есть ли что удалять?
                if (dataUsers.RowCount == 0)
                {
                    return;
                }
                var ind = dataUsers.CurrentRow.Index;
                Users.RemoveAt(ind);
                // if (grid.RowCount == 0)
                // {
                //     ControlsEnabled(false);
                // }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //var ind = dataUsers.CurrentRow.Index;
            //add_dialog.add = false;
            add_order.ShowDialog();
            if (add_order.save)
            {
                Orders.Add(add_order.Order);
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            {
                // А есть ли что удалять?
                if (dataOrders.RowCount == 0)
                {
                    return;
                }
                var ind = dataOrders.CurrentRow.Index;
                Orders.RemoveAt(ind);
                // if (grid.RowCount == 0)
                // {
                //     ControlsEnabled(false);
                // }
            }
        }

        private void btnAddEcon_Click(object sender, EventArgs e)
        {
            //var ind = dataUsers.CurrentRow.Index;
            //add_dialog.add = false;
            add_econ.ShowDialog();
            if (add_econ.save)
            {
                Econs.Add(add_econ.Econ);
            }
        }

        private void btnDelEcon_Click(object sender, EventArgs e)
        {
            // А есть ли что удалять?
            if (dataEcons.RowCount == 0)
            {
                return;
            }
            var ind = dataEcons.CurrentRow.Index;
            Econs.RemoveAt(ind);
            // if (grid.RowCount == 0)
            // {
            //     ControlsEnabled(false);
            // }
        }

    }
}

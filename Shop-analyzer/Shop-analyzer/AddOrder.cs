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
    public partial class AddOrder : Form
    {
        // Стандартное поведение подразумавает добавление
        // public bool add = true;

        // Сохранение формы, свойство :)
        public bool save { get; private set; }

        // Экземпляр класса
        public OrderIndicators Order;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save = true;
            Order = new OrderIndicators();

            Order.Date = inDate.Value;
            Order.Login = inLogin.Text;
            Order.SearchSystem = inSearch.Text;
            Order.IsLid = inLid.Checked;
            Order.NumMerch = (int)inNumMerch.Value;
            Order.Cost = (double)inCost.Value;
            Order.InfoAsked = inInfo.Checked;

            Close();
        }
    }
}
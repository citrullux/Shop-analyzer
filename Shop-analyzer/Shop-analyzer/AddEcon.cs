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
    public partial class AddEcon : Form
    {
        // Сохранение формы, свойство :)
        public bool save { get; private set; }

        // Экземпляр класса
        public EconIndicators Econ;

        public AddEcon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save = true;

            Econ = new EconIndicators();
            //if (add) { User = new UserIndicators(); }

            Econ.MonthSave = (double)inSave.Value;
            Econ.Month = inMonth.Value;
            Econ.En = (double)inEn.Value;
            Econ.HostingPay = (double)inHost.Value;
            Econ.ProgrammerPay = (double)inProg.Value;
            Econ.ClientManagerPay = (double)inCliManager.Value;
            Econ.PromotionPay = (double)inPromotion.Value;
            
            Close();
        }
    }
}

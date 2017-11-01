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
    public partial class AddUser : Form
    {
        // Стандартное поведение подразумавает добавление
       // public bool add = true;
        
        // Сохранение формы, свойство :)
        public bool save { get; private set; }
        
        // Экземпляр класса
        public UserIndicators User;

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save = true;
            User = new UserIndicators();
            //if (add) { User = new UserIndicators(); }
            User.Login = inLogin.Text;
            User.SearchSystem = inSearch.Text;
            User.Registered = inRegister.Value;
            Close();
        }
    }
}

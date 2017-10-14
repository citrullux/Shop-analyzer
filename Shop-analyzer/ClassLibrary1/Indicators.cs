using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicators
{
    public class Indicators
    {
        public Indicators()
        {
            HostingPay = 1;
            ProgrammerPay = 1;
            ClientManagerPay = 1;
            PromotionPay = 1;
        }

        [System.ComponentModel.DisplayName("Экономический эффект за месяц")]
        public double MonthEffect { get { return MonthSave - En * MonthCost; } }
        [System.ComponentModel.DisplayName("Экономия (Прибыль) за месяц")]
        public double MonthSave { get; set; }
        [System.ComponentModel.DisplayName("Нормативный коэффициент эффективности вложений")]
        public double En { get; set; }
        [System.ComponentModel.DisplayName("Ежемесячные затраты на создание ИС")]
        public double MonthCost { get {return HostingPay + ProgrammerPay + ClientManagerPay + PromotionPay; } }
        [System.ComponentModel.DisplayName("Срок окупаемости капитальных вложений")]
        public double T { get { return MonthCost / MonthSave; } }
        [System.ComponentModel.DisplayName("Коэффициент экономический эффективности")]
        public double EconEffic { get { return MonthSave / MonthCost; } }
        [System.ComponentModel.DisplayName("Затраты на хостинг")]
        public double HostingPay { get; set; }
        [System.ComponentModel.DisplayName("Зармлата програмиста")]
        public double ProgrammerPay { get; set; }
        [System.ComponentModel.DisplayName("Зарплата клиент-менеджера")]
        public double ClientManagerPay { get; set; }
        [System.ComponentModel.DisplayName("Реклама и продвижение")]
        public double PromotionPay { get; set; }

    }

}

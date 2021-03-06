﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicators
{
    public class EconIndicators
    {

        public EconIndicators()
        {
            MonthSave = 1;
            HostingPay = 1;
            ProgrammerPay = 1;
            ClientManagerPay = 1;
            PromotionPay = 1;
        }
        [System.ComponentModel.DisplayName("Месяц")]
        public DateTime Month { get; set; }
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
        [System.ComponentModel.DisplayName("Зарплата програмиста")]
        public double ProgrammerPay { get; set; }
        [System.ComponentModel.DisplayName("Зарплата клиент-менеджера")]
        public double ClientManagerPay { get; set; }
        [System.ComponentModel.DisplayName("Реклама и продвижение")]
        public double PromotionPay { get; set; }

    }

    public class InternIndicators
    {
        [System.ComponentModel.DisplayName("Коэффициэнт конверсии интернет магазина")]
        public double NumOfBuy { get; set; }
        [System.ComponentModel.DisplayName("Коэффициент отказов")]
        public double NumOfRegret { get; set; }
        [System.ComponentModel.DisplayName("Число товаров в заказе")]
        public int NumOfMerch { get; set; }
        [System.ComponentModel.DisplayName("Средняя стоимость заказа")]
        public double MiddleCost { get; set; }
        [System.ComponentModel.DisplayName("% завершения заполнения формы")]
        public double LidGen { get; set; }
        [System.ComponentModel.DisplayName("% не заверщённых заполнений формы")]
        public double LidRegret { get; set; }
        [System.ComponentModel.DisplayName("Всего лидов за месяц")]
        public double LidMonth { get; set; }
        [System.ComponentModel.DisplayName("Запросы доп. информации")]
        public double AddInfo { get; set; }
        [System.ComponentModel.DisplayName("Показатель конверсии")]
        public double ConvSign { get; set; }

    }

    public class UserIndicators
    {
        public UserIndicators()
        {
            SearchSystem = "yandex";
            Login = "IONA";
            Registered = DateTime.Now;
        }
        [System.ComponentModel.DisplayName("Поисковая система из которой прищёл")]
        public string SearchSystem { get; set; }
        [System.ComponentModel.DisplayName("Логин")]
        public string Login { get; set; }
        [System.ComponentModel.DisplayName("Зарегистрирован")]
        public DateTime Registered { get; set; }

    }

    public class OrderIndicators
    {
        [System.ComponentModel.DisplayName("Дата заказа")]
        public DateTime Date { get; set; }
        [System.ComponentModel.DisplayName("Поисковая система")]
        public string SearchSystem { get; set; }
        [System.ComponentModel.DisplayName("Логин")]
        public string Login { get; set; }
        [System.ComponentModel.DisplayName("Заверщённость заказа (Лид)")]
        public bool IsLid { get; set; }
        [System.ComponentModel.DisplayName("Количество товаров в заказе")]
        public int NumMerch { get; set; }
        [System.ComponentModel.DisplayName("Стоимость заказа")]
        public double Cost { get; set; }
        [System.ComponentModel.DisplayName("Запрос доп информации")]
        public bool InfoAsked { get; set; }

    }

    public class SignIndicators
    {
        [System.ComponentModel.DisplayName("Конверсия (посещения в деньги)")]
        public double Conversion { get; set; }
        [System.ComponentModel.DisplayName("Стоимость конверсии")]
        public double ConversionCost { get; set; }
        [System.ComponentModel.DisplayName("Рентабельность инвестиций")]
        public double RoI { get; set; }
        [System.ComponentModel.DisplayName("Средний уровень закрытия лида")]
        public double AverageLidClose { get; set; }
        [System.ComponentModel.DisplayName("Стоимость приобретения клиента")]
        public double CustomerCost { get; set; }
        [System.ComponentModel.DisplayName("Самоокупаемость")]
        public double CustomerPay { get; set; }
        [System.ComponentModel.DisplayName("Пожизненная ценность")]
        public double LifetimePay { get; set; }

    }


}

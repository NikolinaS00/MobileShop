﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.DataBase;
using WpfApp1.objects;

namespace WpfApp1.Model
{
    internal class ArticlesViewModel : ObservableObject
    {

        public static ObservableCollection<Article> MobilePhones { get; set; }
        public static ObservableCollection<Article> OtherPhoneEquipment { get; set; }
        public static ObservableCollection<Article> PhoneCases { get; set; }
        public static ObservableCollection<Article> PowerBanks { get; set; }
        public static Article SelectedItem { get; set; }

        public ArticlesViewModel()
        {

            MobilePhones = new ObservableCollection<Article>();     
            OtherPhoneEquipment = new ObservableCollection<Article>();
            PhoneCases = new ObservableCollection<Article>();
            PowerBanks = new ObservableCollection<Article>();

           List<Article> MobPhones = DbMobileShop.GetArticlesByCategory("mobilni telefon");
           List<Article> OtherEquip = DbMobileShop.GetArticlesByCategory("ostala oprema");
           List<Article> PHCases = DbMobileShop.GetArticlesByCategory("maska za telefon");
           List<Article> pwBanks = DbMobileShop.GetArticlesByCategory("punjaci");

            foreach(Article m in MobPhones)
            {
                MobilePhones.Add(m);
            }

            foreach(Article o in OtherEquip)
            {
                OtherPhoneEquipment.Add(o);
            }

            foreach(Article p in PHCases)
            {
                PhoneCases.Add(p);
            }

            foreach(Article p in pwBanks)
            {
                PowerBanks.Add(p);
            }
        }

        public static void RefreshList()
        {

            MobilePhones.Clear();
            OtherPhoneEquipment.Clear();
            PhoneCases.Clear();
            PowerBanks.Clear();
            List<Article> MobPhones = DbMobileShop.GetArticlesByCategory("mobilni telefon");
            List<Article> OtherEquip = DbMobileShop.GetArticlesByCategory("ostala oprema");
            List<Article> PHCases = DbMobileShop.GetArticlesByCategory("maska za telefon");
            List<Article> pwBanks = DbMobileShop.GetArticlesByCategory("punjaci");

            foreach (Article m in MobPhones)
            {
                MobilePhones.Add(m);
            }

            foreach (Article o in OtherEquip)
            {
                OtherPhoneEquipment.Add(o);
            }

            foreach (Article p in PHCases)
            {
                PhoneCases.Add(p);
            }

            foreach (Article p in pwBanks)
            {
                PowerBanks.Add(p);
            }
        }
    }
}

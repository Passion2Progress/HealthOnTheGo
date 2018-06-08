using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NYIT_Health
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;
            else if (item.Title == "Surveys")
            {
                item.TargetType = getSurvey();
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

        public Type getSurvey()
        {
            System.DateTime x = DateTime.Now;

            int hour = x.Hour;
            int minute = x.Minute;

            string a = hour.ToString();
            string b = minute.ToString();
            string c = a + b;
            int time = Int32.Parse(c);

            if (time >= 300 && time <= 1100)
            {
                // 3:00 - 11:00 morning
                surveyPage = typeof(GoodMorining);
            }
            else if (time >= 1101 && time <= 1900)
            {
                // 11:01 - 19:00 evening
                surveyPage = typeof(GoodEvening);
            }
            else if (time >= 1901 || time <= 259)
            {
                // 19:01 - 2:59 night
                surveyPage = typeof(GoodNight);
            }
            else
            {
                surveyPage = typeof(YourDay);
            }

            return surveyPage;
        }

        
        private Type surveyPage;
        
    }
}
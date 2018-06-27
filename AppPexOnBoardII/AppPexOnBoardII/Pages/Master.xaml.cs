using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPexOnBoardII.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
        public Master()
        {
            InitializeComponent();
            //var masterPageItems = new List<MasterPageItem>();
            
            //listView.ItemsSource = masterPageItems;


        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem as MasterPageItem;
            //if (item != null)
            //{
            //    //var page = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            //    App.MasterDetail.Detail.Navigation.PushAsync((Page)Activator.CreateInstance(item.TargetType));
            //    //      listView.SelectedItem = null;
            //    App.MasterDetail.IsPresented = false;
            //}
        }

       
       

        void mantenimiento_Tapped(object sender, System.EventArgs e)
        {
            App.MasterDetail.Detail.Navigation.PushAsync((Page)Activator.CreateInstance(typeof(MantenimientoPg)));
            //      listView.SelectedItem = null;
            App.MasterDetail.IsPresented = false;
        }


      
    }
}
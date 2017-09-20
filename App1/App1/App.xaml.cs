using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterDatail { get; set; }
		public App ()
		{
			InitializeComponent();

            MainPage = new App1.MainPage();
			
		}

	
	}
}

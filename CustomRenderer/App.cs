using BTSxfrag.View;
using Xamarin.Forms;

namespace BTSxfrag
{
	public class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

		public App ()
		{
			//MainPage = new MapPage ();
       // MainPage=new GPSpage();
      // MainPage=new NavigationPage(new GPSpage());
     MainPage=new NavigationPage(new PraincipalPage());
		  

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


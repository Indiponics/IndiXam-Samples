using System;
using Xamarin.Forms;
using IndiXam.Forms.Controls.GestureRecognizers;

namespace GuestureSample
{
	public class App : Application
	{
		public App ()
		{
			Label lbl = new Label (){Text="I've been Flung", IsVisible=false};
            Label lbl2 = new Label (){Text="I've been Tapped", IsVisible=false};
            Label lbl3 = new Label (){Text="I've been Double Tapped", IsVisible=false};

			Label indiLabel = new Label {
				XAlign = TextAlignment.Center,
				Text = "Welcome to Xamarin Forms!-\n Fling Me,Tap Me Call Me Edna",
                FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label))
			};

			// The root page of your application
			TapGestureRecognizer tgr = new TapGestureRecognizer();
			tgr.Tapped+=(s,e)=>
			{
                lbl2.IsVisible = !lbl2.IsVisible;
			};
            indiLabel.GestureRecognizers.Add(tgr);

            TapGestureRecognizer tgr2 = new TapGestureRecognizer();
            tgr2.NumberOfTapsRequired = 2;
            tgr2.Tapped+=(s,e)=>
            {
                lbl3.IsVisible = !lbl3.IsVisible;
            };
            indiLabel.GestureRecognizers.Add(tgr2);


			IndiFlingGestureRecognizer fgr = new IndiFlingGestureRecognizer();
			fgr.Activated+=(s,e)=>
			{
                lbl.IsVisible = !lbl.IsVisible;
			};
			indiLabel.GestureRecognizers.Add(fgr);


			MainPage = new ContentPage {
				Content = new ScrollView{
					Content= new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
							indiLabel,
                            lbl,
                            lbl2,
                            lbl3
						}
					}
				}
			};
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


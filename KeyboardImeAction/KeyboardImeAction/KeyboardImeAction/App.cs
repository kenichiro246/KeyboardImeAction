using Xamarin.Forms;

namespace KeyboardImeAction
{
    public class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = "Welcome to Xamarin Forms !" },
                        new Entry { Placeholder = "Entry" },
                        new CustomEntry { Placeholder = "CustomEntry" }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

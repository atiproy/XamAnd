using Android.App;
using Android.Widget;
using Android.OS;

namespace XamAnd
{
    [Activity(Label = "XamAnd", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate { button.Text = string.Format("{0} Clicks!", count++); };
        }
    }
}


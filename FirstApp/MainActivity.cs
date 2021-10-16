using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //TextView firstText;
        TextView answerTextView;
        EditText firstNumberEditText;
        EditText secondNumberEditText;
        Button addButton;
        Button subtractButton;
        Button multiplyButton;
        Button divideButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //firstText = FindViewById<TextView>(Resource.Id.textView1);
            //var firstButton = FindViewById < Button>(Resource.Id.button1);
             firstNumberEditText = FindViewById<EditText>(Resource.Id.editText1);
             secondNumberEditText = FindViewById<EditText>(Resource.Id.editText2);
             addButton = FindViewById<Button>(Resource.Id.addButton);
             answerTextView = FindViewById<TextView>(Resource.Id.answerTextView);
             subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
             multiplyButton = FindViewById<Button>(Resource.Id.multiplyButton);
             divideButton = FindViewById<Button>(Resource.Id.divideButton);



            //firstText.Text = " Minu esimene tekst";
            //firstButton.Text = "Vajuta mind";
            //firstButton.Click += FirstButton_Click;

            addButton.Click += addButton_Click;
            subtractButton.Click += SubtractButton_Click;
            multiplyButton.Click += MultiplyButton_Click;
            divideButton.Click += DivideButton_Click;
        }

        private void DivideButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber / secondNumber;
            answerTextView.Text = answer.ToString();
        }

        private void MultiplyButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber * secondNumber;
            answerTextView.Text = answer.ToString();
        }

        private void SubtractButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber - secondNumber;
            answerTextView.Text = answer.ToString();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber + secondNumber;
            answerTextView.Text = answer.ToString();
        }

        /*private void FirstButton_Click(object sender, System.EventArgs e)
        {
            firstText.Text = "Juhuu vajutasid nuppu";
        }*/

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
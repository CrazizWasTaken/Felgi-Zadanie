namespace Felgi2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPreviousClicked(object sender, EventArgs e)
        {
            count--;
            if (count == -1)
            {
                count = 9;
            }
            imag.Source = $"f{count}.jpg";
            lettuce.Text = $"nr {count+1}";
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                count = 0;
            }
            imag.Source = $"f{count}.jpg";
            lettuce.Text = $"nr {count+1}";
        }
        private void doe(object sender, EventArgs e)
        {
            if (int.TryParse(john.Text,out int bob))
            {
                if (bob < 11 && bob > 0)
                {
                    count = bob - 1;
                    imag.Source = $"f{count}.jpg";
                    lettuce.Text = $"nr {count + 1}";
                }
            }
        }
    }

}

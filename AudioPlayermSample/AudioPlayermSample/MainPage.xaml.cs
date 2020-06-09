using AudioPlayermSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AudioPlayermSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<AudioItem> AudioItems { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            AudioItems = new List<AudioItem>();
            AudioItems.Add(new AudioItem
            {
                Title = "SampleA",
                Description = "This is Audio Sample A",
                Source = "C:\\Users\\akihi\\source\\testdata\\audio\\sampleA.wma"
            });
            AudioItems.Add(new AudioItem
            {
                Title = "SampleB",
                Description = "This is Audio Sample B",
                Source = "C:\\Users\\akihi\\source\\testdata\\audio\\sampleB.wma"
            });
            AudioItems.Add(new AudioItem
            {
                Title = "SampleC",
                Description = "This is Audio Sample C",
                Source = "C:\\Users\\akihi\\source\\testdata\\audio\\sampleC.wma"
            });

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            AudioItem selectedItem = e.SelectedItem as AudioItem;
            LabelTitile.Text = selectedItem.Title;
            LabelDescription.Text = selectedItem.Description;
        }
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            AudioItem tappedItem = e.Item as AudioItem;
        }
    }
}
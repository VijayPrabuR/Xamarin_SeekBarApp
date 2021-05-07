using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeekBarDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnSeekBarChanged(object sender, ValueChangedEventArgs args)
        {
            if (sender == redSeekBar)
            {
                redText.Text = String.Format("{0:X2}", (int)args.NewValue);
            }
            else if (sender == greenSeekBar)
            {
                greenText.Text = String.Format("{0:X2}", (int)args.NewValue);
            }
            else if (sender == blueSeekBar)
            {
                blueText.Text = String.Format("{0:X2}", (int)args.NewValue);
            }

            boxView.Color = Color.FromRgb((int)redSeekBar.Value,(int)greenSeekBar.Value,(int)blueSeekBar.Value);
        }
    }
}

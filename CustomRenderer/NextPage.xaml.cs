using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class NextPage : ContentPage
    {
        public NextPage(double x, double y)
        {
            InitializeComponent();
            LabelX.Text = x.ToString();
            LabelY.Text = y.ToString();

        }
    }
}

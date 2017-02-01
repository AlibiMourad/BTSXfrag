using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BTSxfrag
{
    public partial class Save : ContentPage
    {
        public Save(string ip,string masque,string de,string vers )
        {
            InitializeComponent();
            Label1.Text = "rest system";
            Label2.Text = "config ipif System ipaddress" + ip + "/" + masque;
            Label3.Text = "config mirror port 1:" + de + " add source port 1:" + de + "-1:" + vers + "both";
            Label4.Text = "create syslog host 1 severity all facility local0 ipaddress" + ip + "state enabled";
            Label5.Text = "enable syslog";
            Label6.Text = "upload cofiguration " + ip + " d:\\sauvegarde.txt";

        }
    }
}

using System.Diagnostics;

using DbhVpnClient.Contracts.Orchestrators;

namespace DbhVpnClient.App
{
    public partial class MainForm : Form
    {
        /*        private readonly IDbhVpnApiClientService _dbhVpnApiClientService;

                MainForm(
                    IDbhVpnApiClientService dbhVpnApiClientService)
                {
                    _dbhVpnApiClientService = dbhVpnApiClientService;
                }
        */

        private bool IsUserAuthenticated = false;

        public MainForm()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAll();
            ShowAccountScreen();
        }




        private void button_menu_Account_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowAccountScreen();

        }

        private void button_menu_Dashboard_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowDashbordScreen();
        }



        private void ShowAccountScreen()
        {
            panel_menu_leftTag.Height = button_menu_Account.Height;
            panel_menu_leftTag.Top = button_menu_Account.Top;

            button_Login.Visible = true;
        }

        private void ShowDashbordScreen()
        {
            panel_menu_leftTag.Height = button_menu_Dashboard.Height;
            panel_menu_leftTag.Top = button_menu_Dashboard.Top;


        }

        private void HideAll()
        {
            button_Login.Visible = false;
        }




        private void button_Login_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated)
                Process.Start(new ProcessStartInfo("https://auth.danbot.host/login?service=vpn.local") { UseShellExecute = true });
        }
    }
}
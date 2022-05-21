using System.Diagnostics;
using DbhVpnClient.Contracts.Orchestrators;

namespace DbhVpnClient.App
{
    public partial class MainForm : Form
    {
        private readonly IDbhVpnApiClientService _dbhVpnApiClientService;
        private readonly IAuthenticationWebsocketService _authenticationWebsocketService;
        private readonly EventHandler AuthProcessCompleted;

        private string ClientIp = "0.0.0.0";

        private bool IsUserAuthenticating = false;
        private bool IsUserAuthenticated = false;

        public MainForm(IDbhVpnApiClientService dbhVpnApiClientService,
            IAuthenticationWebsocketService authenticationWebsocketService)
        {
            _dbhVpnApiClientService = dbhVpnApiClientService;
            _authenticationWebsocketService = authenticationWebsocketService;

            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HideAll();
            ShowAccountScreen();

            button_Dissconnect.Enabled = false;
            ClientIp = await _dbhVpnApiClientService.GetIpAdressAsync();
            label_CurrentIP.Text = ClientIp;
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

        private void Render()
        {
            button_Login.Enabled = !IsUserAuthenticating;
        }


        private async void button_Login_Click(object sender, EventArgs e)
        {
            IsUserAuthenticating = true;

            _authenticationWebsocketService.CreateNewAuthWebSocketAsync("jfsljl", AuthProcessCompleted);

            AuthProcessCompleted += OnUserHasAuthnticated;

            Render();
            if (!IsUserAuthenticated)
                Process.Start(new ProcessStartInfo("http://localhost/auth/create?code=jfsljl") { UseShellExecute = true });
        }
        void AuthProcessCompleted(object sender, EventArgs e)
        {
            //lable_ConnectedTo.Text = jwt;
            Render();
            //Do something here
        }

        public void OnUserHasAuthnticated(object o, EventArgs s)
        {
            IsUserAuthenticated = true;
            IsUserAuthenticating = false;

            AuthProcessCompleted(this, null);
        }
    }
}
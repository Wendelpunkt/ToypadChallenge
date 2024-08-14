using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace Toypad.Launcher.Plugins.MicrosoftTeams
{
    public partial class MicrosoftTeamsControl : UserControl
    {
        public MicrosoftTeamsControl()
        {
            InitializeComponent();

            _ = Task.Run(Do);
        }

        /// <summary>
        /// MSTL.NET Approach
        /// Note: How to get the token into the graph client?
        /// </summary>
        private async Task Do()
        {
            string[] scopes = new string[] { "user.read", "CallRecords.Read.All" };

            IPublicClientApplication app = PublicClientApplicationBuilder
               .Create("c54d5346-b47d-43a0-80c0-551ba2e1b7cc")
               .WithDefaultRedirectUri()
               .Build();

            var accounts = await app.GetAccountsAsync();

            AuthenticationResult result;
            try
            {
                result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                    
                  .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                result = await app.AcquireTokenInteractive(scopes)
                    .WithParentActivityOrWindow(this)
                    .ExecuteAsync();
            }
        }

        /// <summary>
        /// Microsoft Graph approach
        /// Note: Asks for auth every time - no silent login so far
        /// </summary>
        private async Task DoDifferent()
        {
            var scopes = new[] { "User.Read", "CallRecords.Read.All" };

            // Value from app registration
            var clientId = "c54d5346-b47d-43a0-80c0-551ba2e1b7cc";

            // using Azure.Identity;
            var options = new InteractiveBrowserCredentialOptions
            {
                // TenantId = tenantId,
                ClientId = clientId,
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                DisableAutomaticAuthentication = false,
                // LoginHint = "tom.wendel@antme.net",
                RedirectUri = new Uri("http://localhost"),
            };

            // https://learn.microsoft.com/dotnet/api/azure.identity.interactivebrowsercredential
            var interactiveCredential = new InteractiveBrowserCredential(options);

            var graphClient = new GraphServiceClient(interactiveCredential, scopes);

            var me = await graphClient.Me.GetAsync();

            // TODO: Get this to work! Seems that this permission need device auth, not user auth
            var calls = await graphClient.Communications.CallRecords.GetAsync();
        }
    }
}

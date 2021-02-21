using Microsoft.AspNetCore.Components;

namespace Lycan.Web.Layouts.DashboardLayout.Components {
  public partial class LeftSidebarFooter : ComponentBase {  
    [Inject]
    private NavigationManager Navigation { get; set; }

    private bool _sidebarFooterOpen = false;

    private void HandleSidebarFooterClick() {
      _sidebarFooterOpen = !_sidebarFooterOpen;
    }

    private void HandleSidebarFooterLoginClick() {
      Navigation.NavigateTo("https://auth.lycan.info/login?client_id=7kteun21k13defe12o0f92d35g&response_type=code&scope=aws.cognito.signin.user.admin+email+openid+phone+profile&redirect_uri=http://localhost:5050/callback-oidc");
    }
  }
}

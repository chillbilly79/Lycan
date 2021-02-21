using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lycan.Web.Components.Authentication {
  public partial class Login : ComponentBase {
    [Inject]
    NavigationManager Navigation { get; set; }
    [Inject]
    SignOutSessionStateManager SignOutManager { get; set; }

    private async Task BeginSignOut(MouseEventArgs e) {
      await SignOutManager.SetSignOutState();
      Navigation.NavigateTo("authentication/logout");
    }
  }
}

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lycan.Web.Components {
  public partial class LoginDisplay : ComponentBase {
    NavigationManager Navigation { get; set; }
    SignOutSessionStateManager SignOutManager { get; set; }

    async Task BeginSignOut(MouseEventArgs e) {
      await SignOutManager.SetSignOutState();
      Navigation.NavigateTo("authentication/logout");
    }
  }
}

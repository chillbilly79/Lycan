using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lycan.Web.Components.Auth {
  public partial class RedirectToLogin : ComponentBase {
    [Inject]
    NavigationManager Navigation { get; set; }

    protected override void OnInitialized() {
      Navigation.NavigateTo($"authentication/login/returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }
  }
}

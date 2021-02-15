using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;

namespace Lycan.Web.Components {
  public partial class RedirectToLogin : ComponentBase {
    [Inject]
    public NavigationManager Navigation { get; set; }

    protected override void OnInitialized() {
      Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }
  }
}

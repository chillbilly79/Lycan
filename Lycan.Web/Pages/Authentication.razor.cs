using Microsoft.AspNetCore.Components;

namespace Lycan.Web.Pages {
  public partial class Authentication : ComponentBase {
    [Parameter]
    public string Action { get; set; }

    protected override void OnInitialized() {
      
    }
  }
}

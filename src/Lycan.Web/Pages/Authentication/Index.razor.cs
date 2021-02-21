using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lycan.Web.Pages.Authentication {
  public partial class Index : ComponentBase {
    [Parameter]
    public string Action { get; set; }
  }
}

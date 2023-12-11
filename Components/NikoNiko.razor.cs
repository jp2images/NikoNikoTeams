using Microsoft.AspNetCore.Components;
using NikoNikoTeams.Entities;

namespace NikoNikoTeams.Components;

public partial class NikoNiko
{
  [Parameter]
  public List<NikoNikoStatus> NikoNikoItems { get; set; }
}

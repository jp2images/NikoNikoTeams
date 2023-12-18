namespace NikoNikoTeams.Components;

using Microsoft.AspNetCore.Components;
using NikoNikoTeams.Entities;

public partial class NikoNiko
{

  [Parameter] public NikoNikoEntitiy NikoMood { get; set; } = new();

  public NikoNiko()
  {
    var myList = NikoMood.Items;

  }
}


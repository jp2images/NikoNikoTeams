namespace NikoNikoTeams.Components;

using Microsoft.AspNetCore.Components;
using NikoNikoTeams.Entities;

public partial class NikoNikoLegend
{
  private NikoNikoStatus[] _nikoNikoLegendData;
  private NikoNikoStatus _selectedLegendItem;

  [Parameter]
  public List<NikoNikoStatus> NikoNikoMood { get; set; } = new();

}





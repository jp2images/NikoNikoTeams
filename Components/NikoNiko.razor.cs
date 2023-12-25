namespace NikoNikoTeams.Components;

using Microsoft.AspNetCore.Components;
using NikoNikoTeams.Entities;

public partial class NikoNiko
{

  [Parameter] public NikoNikoEntitiy NikoMood { get; set; } = new();
  [Parameter] public List<NikoNikoMood> PickMoodList { get; set; } = new();


  public void AddMood(NikoNikoMood mood)
  {
    PickMoodList.Add(

      new NikoNikoMood
      {
        ImageSource = mood.ImageSource,
        ImageName = mood.ImageName,
        Score = mood.Score,
        Definition = mood.Definition
      });
  }
}


namespace NikoNikoTeams.Components;

using NikoNikoTeams.Entities;

public partial class NikoNiko
{
  /// <summary>
  /// A collection of Emojis to choose one from that represents the current
  /// mood of the user.
  /// </summary>
  public NikoNikoEntitiy NikoMood { get; set; } = new();

  /// <summary>
  /// The collection of emojis overtime from the user.
  /// </summary>
  public List<NikoNikoMood> MoodList { get; set; } = new();

  /// <summary>
  /// This is the selected emoji that the user has picked to represent their
  /// mood for the day.
  /// </summary>
  public NikoNikoMood PickedEmoji { get; set; }


  public void AddMood(NikoNikoMood mood)
  {
    //PickedEmoji = mood;

    MoodList.Add(mood);
    //MoodList.Add(PickedEmoji);
    //MoodList.Add(

    //  new NikoNikoMood
    //  {
    //    ImageSource = mood.ImageSource,
    //    ImageName = mood.ImageName,
    //    Score = mood.Score,
    //    Definition = mood.Definition
    //  });


    int index = MoodList.FindLastIndex(i => i.Equals(mood));
    if (index != -1)
    {
      MoodList[index].Index = index;
      //MoodList[index].IsObjectInCell = true;
    }

    ;
  }

}


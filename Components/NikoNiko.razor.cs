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

  private int ColumnNumber;

  private DayOfWeek _dow;

  protected override void OnInitialized()
  {

    base.OnInitialized();

    _dow = DateOnly.FromDateTime(DateTime.UtcNow).DayOfWeek;

  }

  public void AddMood(NikoNikoMood mood)
  {
    mood.DateEntered = DateOnly.FromDateTime(DateTime.UtcNow);


    for (int i = 0; i < 7; i++)
    {
      if (i == ColumnNumber)
      {
        MoodList.Add(mood);
        mood.Index = i;
        mood.IsObjectInCell = true;
      }
      else
      {
        MoodList.Add(new NikoNikoMood());
        //{
        //  Score = -99,
        //  ImageName = null, 
        //  ImageSource = null,
        //  Definition = null,
        //  Index = -1,
        //  IsObjectInCell = false,
        //  DateEntered = null
        //});
        mood.Index = i;
        mood.IsObjectInCell = false;
      }
    }

    MoodList.Add(mood);



    //int index = MoodList.FindLastIndex(i => i.Equals(mood));
    //if (index != -1)
    //{
    //  MoodList[index].Index = index;
    //  //MoodList[index].IsObjectInCell = true;
    //}

    ;
  }

}


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

  private int loopCounter = 0;

  private DayOfWeek _dow;

  protected override void OnInitialized()
  {
    base.OnInitialized();
    _dow = DateOnly.FromDateTime(DateTime.UtcNow).DayOfWeek;
  }

  public void AddMood(NikoNikoMood mood)
  {
    mood.DateEntered = DateOnly.FromDateTime(DateTime.UtcNow);
    MoodList.Add(mood);
    ;
  }

}


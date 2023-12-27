namespace NikoNikoTeams.Entities;

public class NikoNikoMood
{
  public string ImageSource { get; set; }
  public string ImageName { get; set; }
  public int Score { get; set; }
  public string Definition { get; set; }

  public int Index { get; set; }
  //public object SelectedObject { get; set; }
  public bool IsObjectInCell { get; set; }

  public DateOnly DateEntered { get; set; }
}

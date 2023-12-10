namespace NikoNikoTeams.Entities;

public class NikoNikoLegendDataItem
{
  public NikoNikoLegendDataItem(string imageSource)
  {
    ImageSource = imageSource;

    ImageName = imageSource.Substring(imageSource.LastIndexOf("/", StringComparison.Ordinal) + 1,
      imageSource.LastIndexOf(".", StringComparison.Ordinal) - imageSource.LastIndexOf("/", StringComparison.Ordinal) - 1);
  }

  public string ImageSource { get; set; }
  public string ImageName { get; set; }
  public int Score { get; set; }
  public string Definition { get; set; }

}


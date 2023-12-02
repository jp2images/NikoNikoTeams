using Microsoft.AspNetCore.Components;

namespace NikoNikoTeams.Components;

public partial class NikoNikoLegend
{
  private NikoNikoLegendDataItem[] _nikoNikoLegendData;
  private NikoNikoLegendDataItem _selectedLegendItem;

  [Parameter]
  public List<NikoNikoLegendDataItem> NikoNikoLegendItems { get; set; } = new()
  {
    // Build a list of predefined objects that will be used to populate the UI
    // This could be replaced with a call to an API or a database, but because
    // these images shouldn't change it is fine to hard code them.
    
    new NikoNikoLegendDataItem("Images/Angry.png")
    {
      Score = -5,
      Definition="Emotionally distraught and my performance is impacted"
    },

    new NikoNikoLegendDataItem("Images/Anxious Sweat.png")
    {
      Score = -4,
      Definition="Overwhelmed with the tasks and or workload."
    },

    new NikoNikoLegendDataItem("Images/Grimacing.png")
    {
      Score = -3,
      Definition="I don't agree with the direction or am unhappy with the work"
    },

    new NikoNikoLegendDataItem("Images/Frowning.png")
    {
      Score = -2,
      Definition="Unhappy with the results"
    },

    new NikoNikoLegendDataItem("Images/Confused.png")
    {
      Score = -1,
      Definition="Perplexed, might be misunderstanding the direction."
    },

    new NikoNikoLegendDataItem("Images/Neutral.png")
    {
      Score = 0,
      Definition="Not engaged on either side, indifferent"
    },


    new NikoNikoLegendDataItem("Images/Slightly Smiling.png")
    {
      Score = 1,
      Definition="Happy with work and tasks"
    },

    new NikoNikoLegendDataItem("Images/Grinning.png")
    {
      Score = 2,
      Definition="Generally happy and satisfied."
    },

    new NikoNikoLegendDataItem("Images/Smiling Sunglasses.png")
    {
      Score = 3,
      Definition="Happy with work, performance and workload."
    },

    new NikoNikoLegendDataItem("Images/Nerd.png")
    {
      Score = 4,
      Definition="Feeling especially challenged and rewarded, on top of my game."
    }
  };
}

public class NikoNikoLegendDataItem
{
  public NikoNikoLegendDataItem(string imageSource)
  {
    ImageSource = imageSource;

    ImageName = imageSource.Substring(imageSource.LastIndexOf("/") + 1,
      imageSource.LastIndexOf(".", StringComparison.Ordinal) - imageSource.LastIndexOf("/") - 1);
  }

  public string ImageSource { get; set; }
  public string ImageName { get; set; }
  public int Score { get; set; }
  public string Definition { get; set; }
}


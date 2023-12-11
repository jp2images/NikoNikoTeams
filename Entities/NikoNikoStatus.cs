namespace NikoNikoTeams.Entities;

public class NikoNikoStatus
{
  public string ImageSource { get; set; }
  public string ImageName { get; set; }
  public int Score { get; set; }
  public string Definition { get; set; }


  public static List<NikoNikoStatus> Items { get; set; } = new()
  {
    // Build a list of predefined objects that will be used to populate the UI
    // This could be replaced with a call to an API or a database, but because
    // these images shouldn't change it is fine to hard code them.
    
    new NikoNikoStatus()
    {
      ImageSource="Images/Angry.png",
      ImageName="",
      Score = -5,
      Definition="Emotionally distraught and my performance is impacted"
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Anxious Sweat.png",
      ImageName="",
      Score = -4,
      Definition="Overwhelmed with the tasks and or workload."
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Grimacing.png",
      ImageName="",
      Score = -3,
      Definition="I don't agree with the direction or am unhappy with the work"
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Frowning.png",
      ImageName="",
      Score = -2,
      Definition="Unhappy with the results"
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Confused.png",
      ImageName="",
      Score = -1,
      Definition="Perplexed, might be misunderstanding the direction."
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Neutral.png",
      ImageName="",
      Score = 0,
      Definition="Not engaged on either side, indifferent"
    },


    new NikoNikoStatus()
    {
      ImageSource="Images/Slightly Smiling.png",
      ImageName="",
      Score = 1,
      Definition="Happy with work and tasks"
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Grinning.png",
      ImageName="",
      Score = 2,
      Definition="Generally happy and satisfied."
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Smiling Sunglasses.png",
      ImageName="",
      Score = 3,
      Definition="Happy with work, performance and workload."
    },

    new NikoNikoStatus()
    {
      ImageSource="Images/Nerd.png",
      ImageName="",
      Score = 4,
      Definition="Feeling especially challenged and rewarded, on top of my game."
    }
  };


}





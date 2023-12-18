namespace NikoNikoTeams.Entities;

public class NikoNikoEntitiy
{

  public List<NikoNikoMood> Items { get; set; } = new()
  {

  // Build a list of predefined objects that will be used to populate the UI
  // This could be replaced with a call to an API or a database, but because
  // these images shouldn't change it is fine to hard code them.
  
    new NikoNikoMood
    {
      ImageSource = "Images/Angry.png",
      ImageName = "Angry",
      Score = -5,
      Definition = "Emotionally distraught and my performance is impacted"
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Anxious Sweat.png",
      ImageName = "Anxious",
      Score = -4,
      Definition = "Overwhelmed with the tasks and or workload."
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Grimacing.png",
      ImageName = "Grimacing",
      Score = -3,
      Definition = "I don't agree with the direction or am unhappy with the work"
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Frowning.png",
      ImageName = "Frowning",
      Score = -2,
      Definition = "Unhappy with the results"
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Confused.png",
      ImageName = "Confused",
      Score = -1,
      Definition = "Perplexed, might be misunderstanding the direction."
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Neutral.png",
      ImageName = "Neutral",
      Score = 0,
      Definition = "Not engaged on either side, indifferent"
    },


    new NikoNikoMood
    {
      ImageSource = "Images/Slightly Smiling.png",
      ImageName = "Smiling",
      Score = 1,
      Definition = "Happy with work and tasks"
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Grinning.png",
      ImageName = "Grinning",
      Score = 2,
      Definition = "Generally happy and satisfied."
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Smiling Sunglasses.png",
      ImageName = "Happy",
      Score = 3,
      Definition = "Happy with work, performance and workload."
    },

    new NikoNikoMood
    {
      ImageSource = "Images/Nerd.png",
      ImageName = "Nerd",
      Score = 4,
      Definition = "Feeling especially challenged and rewarded, on top of my game."
    }
  };

}


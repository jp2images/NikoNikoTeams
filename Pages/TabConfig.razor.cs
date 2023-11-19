using NikoNikoTeams.Interop.TeamsSDK;

namespace NikoNikoTeams.Pages;

public partial class TabConfig
{

  private Guid _entityId = Guid.NewGuid();

  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    if (firstRender)
    {
      var settings = new TeamsInstanceSettings
      {
        SuggestedDisplayName = "Team Metrics",
        EntityId = _entityId.ToString(),
        ContentUrl = $"{NavigationManager.BaseUri}/tab",
        WebsiteUrl = $"{NavigationManager.BaseUri}/tab"
      };

      await MicrosoftTeams.InitializeAsync();
      await MicrosoftTeams.RegisterOnSaveHandlerAsync(settings);

    }
  }
}

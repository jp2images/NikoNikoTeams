using Microsoft.AspNetCore.Components;
using Microsoft.TeamsFx;
using NikoNikoTeams.Interop.TeamsSDK;

namespace NikoNikoTeams.Components;

public partial class Welcome
{
  private string _userName;
  private string _userPhotoUri;
  private string _city;
  private string _mobilePhone;
  private string _errorMessage;
  private bool _isInTeams;
  private bool _isLoading = true;

  [Inject] MicrosoftTeams TeamsFx { get; set; }
  [Inject] TeamsUserCredential TeamsUserCredential { get; set; }



  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    await base.OnAfterRenderAsync(firstRender);

    if (firstRender)
    {
      _isInTeams = await TeamsFx.IsInTeams();

      if (_isInTeams)
      {
        var user = await TeamsUserCredential.GetUserInfoAsync();
        _userName = user.DisplayName;

        //_userPhotoUri = user.;
        //_userName = user.PreferredUserName; //This is the email address
        //_city = user.City;
        //_mobilePhone = user.MobilePhone;
      }
      else
      {
        _errorMessage = "Not running in Microsoft Teams.";
      }

      _isLoading = false;
      StateHasChanged();
    }
  }

  private string GetEnvironmentName()
  {
    return HostEnvironment.IsDevelopment() ? "local environment" : "Azure environment";
  }
}


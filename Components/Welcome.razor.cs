namespace NikoNikoTeams.Components;

public partial class Welcome
{
  string _userName;
  private string _city;
  private string _mobilePhone;
  string _errorMessage;
  bool _isInTeams;
  bool _isLoading = true;

  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    await base.OnAfterRenderAsync(firstRender);

    if (firstRender)
    {
      _isInTeams = await MicrosoftTeams.IsInTeams();

      if (_isInTeams)
      {
        var user = await teamsUserCredential.GetUserInfoAsync();
        _userName = user.DisplayName;
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


namespace NikoNikoTeams.Components;

using Azure.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.TeamsFx;

public partial class Graph
{

  [Inject] private TeamsFx Teamsfx { get; set; }

  [Inject] TeamsUserCredential TeamsUserCredential { get; set; }
  [Parameter] public string ErrorMessage { get; set; }

  public bool IsLoading { get; set; }
  public bool NeedConsent { get; set; }
  public User Profile { get; set; }
  public string UserPhotoUri { get; set; }

  private readonly string _scope = "User.Read";

  protected override async Task OnInitializedAsync()
  {
    IsLoading = true;
    if (await HasPermission(_scope))
    {
      await ShowProfile();
    }
  }

  private async Task ShowProfile()
  {
    IsLoading = true;
    var graph = GetGraphServiceClient();

    Profile = await graph.Me.GetAsync();
    UserPhotoUri = await GetPhotoAsync(graph);

    IsLoading = false;
    ErrorMessage = string.Empty;
  }

  private async Task ConsentAndShow()
  {
    try
    {
      await TeamsUserCredential.LoginAsync(_scope);
      NeedConsent = false;
      await ShowProfile();
    }
    catch (ExceptionWithCode e)
    {
      ErrorMessage = e.Message;
    }
  }

  private async Task<bool> HasPermission(string scope)
  {
    IsLoading = true;
    try
    {
      await TeamsUserCredential.GetTokenAsync(new TokenRequestContext(new string[] { _scope }), new System.Threading.CancellationToken());
      return true;
    }
    catch (ExceptionWithCode e)
    {
      if (e.Code == ExceptionCode.UiRequiredError)
      {
        NeedConsent = true;
      }
      else
      {
        ErrorMessage = e.Message;
      }

    }
    IsLoading = false;
    return false;
  }

  private GraphServiceClient GetGraphServiceClient()
  {
    var msGraphAuthProvider = new MsGraphAuthProvider(TeamsUserCredential, _scope);
    var client = new GraphServiceClient(msGraphAuthProvider);
    return client;
  }

  private async Task<string> GetPhotoAsync(GraphServiceClient graph)
  {
    string userPhoto = "";
    try
    {
      var photoStream = await graph.Me.Photo.Content.GetAsync();

      if (photoStream != null)
      {
        // Copy the photo stream to a memory stream
        // to get the bytes out of it
        var memoryStream = new MemoryStream();
        photoStream.CopyTo(memoryStream);
        var photoBytes = memoryStream.ToArray();

        // Generate a data URI for the photo
        userPhoto = $"data:image/png;base64,{Convert.ToBase64String(photoBytes)}";
      }
    }
    catch (Exception) { /* Unable to get the users photo */ }

    return userPhoto;
  }

}


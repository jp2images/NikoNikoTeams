
namespace NikoNikoTeams.Components;

using Microsoft.AspNetCore.Components;

public partial class CurrentUser
{
  [Parameter] public string UserName { get; set; }
  [Parameter] public string UserPhotoUri { get; set; }
  [Parameter] public string City { get; set; }
  [Parameter] public string MobilePhone { get; set; }
  [Parameter] public string[] OtherEmails { get; set; }



}
using cleanarchusingtemplatesteavesmith.Web.ContributorEndpoints;

namespace cleanarchusingtemplatesteavesmith.Web.Endpoints.ContributorEndpoints;
public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}

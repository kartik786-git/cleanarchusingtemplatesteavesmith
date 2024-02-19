using cleanarchusingtemplatesteavesmith.Web.ContributorEndpoints;

namespace cleanarchusingtemplatesteavesmith.Web.Endpoints.ContributorEndpoints;
public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}

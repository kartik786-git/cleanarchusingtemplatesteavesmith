using Ardalis.Result;
using Ardalis.SharedKernel;

namespace cleanarchusingtemplatesteavesmith.UseCases.Contributors.Get;
public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;

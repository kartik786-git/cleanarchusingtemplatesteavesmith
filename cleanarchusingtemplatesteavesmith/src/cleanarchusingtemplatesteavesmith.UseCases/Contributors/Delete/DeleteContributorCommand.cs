using Ardalis.Result;
using Ardalis.SharedKernel;

namespace cleanarchusingtemplatesteavesmith.UseCases.Contributors.Delete;
public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;

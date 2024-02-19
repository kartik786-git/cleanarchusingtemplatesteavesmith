using Ardalis.Result;
using Ardalis.SharedKernel;
using cleanarchusingtemplatesteavesmith.Core.ContributorAggregate;
using cleanarchusingtemplatesteavesmith.Core.ContributorAggregate.Events;
using cleanarchusingtemplatesteavesmith.Core.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace cleanarchusingtemplatesteavesmith.Core.Services;
public class DeleteContributorService(IRepository<Contributor> _repository,
  IMediator _mediator,
  ILogger<DeleteContributorService> _logger) : IDeleteContributorService
{
  public async Task<Result> DeleteContributor(int contributorId)
  {
    _logger.LogInformation("Deleting Contributor {contributorId}", contributorId);
    var aggregateToDelete = await _repository.GetByIdAsync(contributorId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ContributorDeletedEvent(contributorId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}

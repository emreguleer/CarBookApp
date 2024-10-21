using CarBookApp.Application.Features.CQRS.Commands.AboutCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _repo;

        public RemoveAboutCommandHandler(IRepository<About> repo)
        {
            _repo = repo;
        }
        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repo.GetByIdAsync(command.Id);
            await _repo.RemoveAsync(value);
        }
    }
}

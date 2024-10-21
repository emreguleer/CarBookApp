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
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repo;

        public UpdateAboutCommandHandler(IRepository<About> repo)
        {
            _repo = repo;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var values = await _repo.GetByIdAsync(command.AboutId);
            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageUrl = command.ImageUrl;
            await _repo.UpdateAsync(values);

        }
    }
}

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
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<About> _repo;

        public CreateAboutCommandHandler(IRepository<About> repo)
        {
            _repo = repo;
        }
        public async Task Handle(CreateAboutCommand command)
        {
            await _repo.CreateAsync(new About
            {
                Title = command.Title,
                Description = command.Description,
                ImageUrl = command.ImageUrl,
            });
        }
    }
}

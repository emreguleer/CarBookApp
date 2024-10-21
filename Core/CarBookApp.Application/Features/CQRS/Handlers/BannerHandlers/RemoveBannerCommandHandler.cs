using CarBookApp.Application.Features.CQRS.Commands.AboutCommands;
using CarBookApp.Application.Features.CQRS.Commands.BannerCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repo;

        public RemoveBannerCommandHandler(IRepository<Banner> repo)
        {
            _repo = repo;
        }
        public async Task Handle(RemoveBannerCommand command)
        {
            var value = await _repo.GetByIdAsync(command.Id);
            await _repo.RemoveAsync(value);
        }
    }
}

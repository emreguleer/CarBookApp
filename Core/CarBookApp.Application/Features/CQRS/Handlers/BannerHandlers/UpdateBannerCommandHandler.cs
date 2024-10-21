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
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repo;

        public UpdateBannerCommandHandler(IRepository<Banner> repo)
        {
            _repo = repo;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repo.GetByIdAsync(command.BannerId);
            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoUrl = command.VideoUrl;
            values.VideoDescription = command.VideoDescription;
            await _repo.UpdateAsync(values);

        }
    }
}

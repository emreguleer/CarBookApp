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
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repo;

        public CreateBannerCommandHandler(IRepository<Banner> repo)
        {
            _repo = repo;
        }
        public async Task Handle(CreateBannerCommand command)
        {
            await _repo.CreateAsync(new Banner
            {
                Title = command.Title,
                Description = command.Description,
                VideoDescription = command.VideoDescription,
                VideoUrl = command.VideoUrl,
            });
        }
    }
}

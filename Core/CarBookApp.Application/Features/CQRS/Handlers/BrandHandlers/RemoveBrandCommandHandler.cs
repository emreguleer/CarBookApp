using CarBookApp.Application.Features.CQRS.Commands.BannerCommands;
using CarBookApp.Application.Features.CQRS.Commands.BrandCommands;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repo;

        public RemoveBrandCommandHandler(IRepository<Brand> repo)
        {
            _repo = repo;
        }
        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _repo.GetByIdAsync(command.Id);
            await _repo.RemoveAsync(value);
        }
    }
}

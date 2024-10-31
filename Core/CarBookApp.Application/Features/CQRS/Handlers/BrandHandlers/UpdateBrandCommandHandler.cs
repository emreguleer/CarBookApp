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
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repo;

        public UpdateBrandCommandHandler(IRepository<Brand> repo)
        {
            _repo = repo;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repo.GetByIdAsync(command.BrandId);
            values.Name = command.Name;
            await _repo.UpdateAsync(values);

        }
    }
}

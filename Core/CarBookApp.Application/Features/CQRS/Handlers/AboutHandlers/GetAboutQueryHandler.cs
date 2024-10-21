using CarBookApp.Application.Features.CQRS.Results.AboutResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repo;

        public GetAboutQueryHandler(IRepository<About> repo)
        {
            _repo = repo;
        }
        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repo.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutId = x.AboutId,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,

            }).ToList();
        }
    }
}

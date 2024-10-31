using CarBookApp.Application.Features.CQRS.Queries.BannerQueries;
using CarBookApp.Application.Features.CQRS.Queries.BrandQueries;
using CarBookApp.Application.Features.CQRS.Results.BannerResults;
using CarBookApp.Application.Features.CQRS.Results.BrandResults;
using CarBookApp.Application.Interfaces;
using CarBookApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repo;

        public GetBrandByIdQueryHandler(IRepository<Brand> repo)
        {
            _repo = repo;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repo.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = values.BrandId,
                Name = values.Name,
            };
        }
    }
}
}

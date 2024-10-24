﻿using CarBookApp.Application.Features.CQRS.Queries.AboutQueries;
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
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repo;

        public GetAboutByIdQueryHandler(IRepository<About> repo)
        {
            _repo = repo;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repo.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutId = values.AboutId,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title,
            };
        }
    }
}

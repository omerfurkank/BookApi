﻿using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.CreateRangeAuthor;
using Application.Features.Authors.Commands.DeleteAuthor;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetByIdAuthor;
using Application.Features.Authors.Queries.GetListAuthor;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Author, CreateAuthorCommandResponse>().ReverseMap();
        CreateMap<Author, CreateAuthorCommandRequest>().ReverseMap();

        CreateMap<CreateRangeAuthorCommandRequest.AuthorDto, Author>().ReverseMap();
        //CreateMap<List<Author>, CreateRangeAuthorCommandResponse>().ReverseMap();

        CreateMap<Author, UpdateAuthorCommandResponse>().ReverseMap();
        CreateMap<Author, UpdateAuthorCommandRequest>().ReverseMap();

        CreateMap<Author, DeleteAuthorCommandResponse>().ReverseMap();
        CreateMap<Author, DeleteAuthorCommandRequest>().ReverseMap();

        CreateMap<Author, GetByIdAuthorQueryResponse>().ReverseMap();
        CreateMap<Author, GetListAuthorQueryResponse>().ReverseMap();

    }
}
﻿using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreateBookCommandRequest : IRequest<CreateBookCommandResponse>
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
}

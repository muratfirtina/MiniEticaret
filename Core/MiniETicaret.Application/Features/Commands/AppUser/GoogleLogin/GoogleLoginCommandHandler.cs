using MediatR;
using MiniETicaret.Application.Abstractions.Services;


namespace MiniETicaret.Application.Features.Commands.AppUser.GoogleLogin;

public class GoogleLoginCommandHandler : IRequestHandler<GoogleLoginCommandRequest, GoogleLoginCommandResponse>
{
    readonly IAuthService _authService;

    public GoogleLoginCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<GoogleLoginCommandResponse> Handle(GoogleLoginCommandRequest request,
        CancellationToken cancellationToken)
    {
        var token = await _authService.GoogleLoginAsync(request.IdToken, 60*60);
        return new() { Token = token };
    }
}
namespace MiniETicaret.Application.Abstractions.Token;

public interface ITokenHandler
{
    DTOs.Token CreateAccessToken(int second);
    //void RevokeRefreshToken(Domain.Entities.Identity.AppUser user);
    //Task<AccessToken> RefreshAccessToken(string refreshToken);
}
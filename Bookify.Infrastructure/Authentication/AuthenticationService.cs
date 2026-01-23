using Bookify.Application.Abstractions.Authentication;
using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Authentication;

internal sealed class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _httpClient;

    public AuthenticationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public Task<string> RegisterAsync(User user, string password, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

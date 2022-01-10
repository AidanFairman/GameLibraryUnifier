using GameLibraryUnifier.Credentials;

namespace GameLibraryUnifier.Service
{
    public interface IService
    {
        IToken login(ICredentials credentials);
    }
}
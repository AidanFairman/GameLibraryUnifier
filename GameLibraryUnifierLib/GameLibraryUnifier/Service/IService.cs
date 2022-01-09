using GameLibraryUnifier.Credentials;

namespace GameLibraryUnifier.Service{
    public interface IService{
        IToken getToken(ICredential credentials);
    }
}
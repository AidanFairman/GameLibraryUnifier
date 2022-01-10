using GameLibraryUnifier.Credentials;

namespace GameLibraryUnifier.Service
{
    public class BaseService : IService
    {
        protected string baseURL;
        protected string loginUrlPath;
        protected IToken token;
        protected ICredentials credentials;
        public IToken login(ICredentials credentials){
           return null; 
        }
    }
}
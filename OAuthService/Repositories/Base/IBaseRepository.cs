using System;

namespace OAuthService.Repositories.Base
{
    public interface IBaseRepository<TEntity, TViewModel>
        where TEntity : class
        where TViewModel : class
    {
        
    }
}

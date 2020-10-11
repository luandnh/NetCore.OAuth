using System;

namespace OAuthService.Repositories.Base
{
    public class BaseRepository<TEntity, TViewModel> : IBaseRepository<TEntity, TViewModel>
        where TEntity : class
        where TViewModel : class
    {
        public BaseRepository()
        {

        }
        public IBaseRepository<TEntity, TViewModel> CreateRepository()
        {
            var repo = new BaseRepository<TEntity, TViewModel>();
            return repo;
        }
    }
}

using System;
using OAuthService.Repositories.Base;

namespace OAuthService.Services.Base
{
    public class BaseService<TEntity, TViewModel, TRepo> : IBaseService<TEntity, TViewModel, TRepo>
        where TEntity : class
        where TViewModel : class
        where TRepo : IBaseRepository<TEntity, TViewModel>
    {
        private IBaseRepository<TEntity, TViewModel> _repo { get; set; }
        public IBaseRepository<TEntity, TViewModel> repo { get; set; }
        public BaseService()
        {
            repo = new BaseRepository<TEntity, TViewModel>();
            _repo = repo;
        }
        public TViewModel mapEtoVM(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TViewModel mapEtoVM(TEntity entity, TViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public TEntity mapVMtoE(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public TEntity mapVMtoE(TViewModel model, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

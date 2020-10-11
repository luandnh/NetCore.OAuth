using System;
using OAuthService.Repositories.Base;

namespace OAuthService.Services.Base
{
    public interface IBaseService<TEntity, TViewModel, TRepo>
        where TEntity : class
        where TViewModel : class
        where TRepo : IBaseRepository<TEntity,TViewModel>                     
    {
        TViewModel mapEtoVM(TEntity entity);
        TViewModel mapEtoVM(TEntity entity, TViewModel viewModel);
        TEntity mapVMtoE(TViewModel model);
        TEntity mapVMtoE(TViewModel model, TEntity entity);
    }
}

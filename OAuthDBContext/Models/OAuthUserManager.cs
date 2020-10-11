using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OAuthDBContext.Models
{
    public class OAuthUserManager : UserManager<OAuthUser>
    {
        public OAuthUserManager(IUserStore<OAuthUser> userStore,
                                    IOptions<IdentityOptions> optionsAccessor,
                                    IPasswordHasher<OAuthUser> passwordHasher,
                                    IEnumerable<IUserValidator<OAuthUser>> userValidators,
                                    IEnumerable<IPasswordValidator<OAuthUser>> passwordValidators,
                                    ILookupNormalizer keyNormalizer,
                                    IdentityErrorDescriber errors,
                                    IServiceProvider services,
                                    ILogger<UserManager<OAuthUser>> logger)
                                    : base(userStore,
                                    optionsAccessor,
                                    passwordHasher,
                                    userValidators,
                                    passwordValidators,
                                    keyNormalizer,
                                    errors,
                                    services,
                                    logger)
        {

        }


    }
}

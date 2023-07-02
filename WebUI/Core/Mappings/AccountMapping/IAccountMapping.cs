using System.Collections.Generic;
using WebUI.Core.Entities;
using WebUI.Entities.Models;

namespace WebUI.Core.Mappings.AccountMapping
{
    public interface IAccountMapping
    {
        Account CreateAccountModelToAccount(CreateAccountModel model);
    }
}

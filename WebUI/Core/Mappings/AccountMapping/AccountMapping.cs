using WebUI.Core.Entities;
using WebUI.Entities.Models;

namespace WebUI.Core.Mappings.AccountMapping
{
    public class AccountMapping : IAccountMapping
    {
        public Account CreateAccountModelToAccount(CreateAccountModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                Balance = model.Balance,
                UserId = model.UserId,
            };
        }
    }
}

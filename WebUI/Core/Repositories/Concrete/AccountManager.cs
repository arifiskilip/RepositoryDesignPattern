using WebUI.Core.Entities;
using WebUI.Core.Repositories.Abstract;
using WebUI.Entities.Context;

namespace WebUI.Core.Repositories.Concrete
{
    public class AccountManager : GenericRepository<Account>, IAccountService
    {
        private readonly MiniTransferContext _context;

        public AccountManager(MiniTransferContext context) : base(context)
        {
            _context = context;
        }
    }
}

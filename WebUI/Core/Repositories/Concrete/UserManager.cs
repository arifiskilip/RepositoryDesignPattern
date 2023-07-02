using WebUI.Core.Entities;
using WebUI.Core.Repositories.Abstract;
using WebUI.Entities.Context;

namespace WebUI.Core.Repositories.Concrete
{
    public class UserManager : GenericRepository<User>, IUserService
    {
        private readonly MiniTransferContext _context;

        public UserManager(MiniTransferContext context) : base(context)
        {
            _context = context;
        }
    }
}

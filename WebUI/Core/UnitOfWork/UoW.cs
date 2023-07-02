using WebUI.Entities.Context;

namespace WebUI.Core.UnitOfWork
{
    public class UoW : IUoW
    {
        private readonly MiniTransferContext _context;

        public UoW(MiniTransferContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

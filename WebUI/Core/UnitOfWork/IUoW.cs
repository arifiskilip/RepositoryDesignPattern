using WebUI.Entities.Context;

namespace WebUI.Core.UnitOfWork
{
    public interface IUoW
    {
        void Commit();
    }
}

using OOPWithNLayer.DataAccessLayer.Abstract;
using OOPWithNLayer.DataAccessLayer.Repositories;
using OOPWithNLayer.Entity.Concrete;

namespace OOPWithNLayer.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
}

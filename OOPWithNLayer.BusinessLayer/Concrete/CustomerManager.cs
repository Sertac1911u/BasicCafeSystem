using OOPWithNLayer.BusinessLayer.Abstract;
using OOPWithNLayer.DataAccessLayer.Abstract;
using OOPWithNLayer.Entity.Concrete;
using System.Collections.Generic;

namespace OOPWithNLayer.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if(entity.CustomerName!="" && entity.CustomerName.Length>=3 && entity.CustomerCity!=null 
                && entity.CustomerSurname!="" && entity.CustomerName.Length<=30)
            {
                _customerDal.Insert(entity);
            }
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}

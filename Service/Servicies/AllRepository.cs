using Service.IServicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repository.Repositories.Class1;

namespace Service.Servicies
{
    public class AllRepository<T> : IAllService<T> where T : class
    {
        AllRepository<T> _repository = new AllRepository<T>();
        public AllRepository() { }

        public AllRepository(AllRepository<T> repository)
        {
            _repository = repository;
        }

        public bool CreateObj(T obj)
        {
            return _repository.CreateObj(obj);
        }

        public bool DeleteObj(T obj)
        {
            return _repository.DeleteObj(obj);
        }

        public ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetByID(dynamic id)
        {
            return _repository.GetByID(id);
        }

        public bool UpdateObj(T obj)
        {
            return _repository.UpdateObj(obj);
        }
    }
}

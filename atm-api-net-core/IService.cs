using System.Collections.Generic;

namespace atm_api_net_core
{
    public interface IService<Entity, rqCreate, rqUpdate>
    {
        public List<Entity> Find();
        
        public Entity FindById(int id);

        public Entity Create(rqCreate request);

        public Entity Update(int id, rqUpdate entity);

        public bool Delete(int id);

    }
}

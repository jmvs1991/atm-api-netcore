using System.Collections.Generic;

namespace atm_api_net_core
{
    interface IService<Entity, rqCreate>
    {
        public List<Entity> Find();
        
        public Entity FindById(int id);

        public Entity Create(rqCreate request);

        public Entity Update(Entity entity);

        public bool Delete(int id);

    }
}

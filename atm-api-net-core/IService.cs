using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atm_api_net_core
{
    interface IService<Entity>
    {

        public List<Entity> Find();

        public Entity FindById(int id);



    }
}

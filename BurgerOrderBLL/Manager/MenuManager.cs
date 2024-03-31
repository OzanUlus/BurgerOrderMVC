using AutoMapper;
using BurgerAppDtos.Concrate;
using BurgerOrderBLL.Service.Contrate;
using BurgerOrderDAL.Abstract;
using BurgerOrderDAL.Repos;
using BurgerOrderEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerOrderBLL.Manager
{
    public class MenuManager : BaseManager<Menu,MenuDto>, IMenuService
    {

        public MenuManager(IMapper mapper, IUow uow) : base(mapper,uow)
        {
            
        }
    }
}

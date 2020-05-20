using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlowDI.SlowDis
{
    public interface ISlowDiRepository : IRepository<SlowDiEntity> 
    {
    }
}

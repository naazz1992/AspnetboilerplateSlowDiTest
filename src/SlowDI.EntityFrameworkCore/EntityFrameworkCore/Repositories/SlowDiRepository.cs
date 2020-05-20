using Abp.EntityFrameworkCore;
using SlowDI.SlowDis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlowDI.EntityFrameworkCore.Repositories
{
    public class SlowDiRepository : SlowDIRepositoryBase<SlowDiEntity>, ISlowDiRepository
    {
        public SlowDiRepository(IDbContextProvider<SlowDIDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhXuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MinhXuShopDbContext dbContext;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MinhXuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MinhXuShopDbContext());
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }

    }

}

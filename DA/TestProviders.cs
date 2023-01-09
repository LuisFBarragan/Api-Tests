using DA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class TestProviders
    {
        public async Task<IEnumerable<vAdditionalContactInfo>> LeerVista()
        {
            try
            {
                using (Entities context = new Entities())
                {

                    return await context.vAdditionalContactInfo.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

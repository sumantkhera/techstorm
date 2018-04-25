using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Mapping
{
    public class AutoMapperConfiguration
    {
        #region Methods
        /// <summary>
        /// Automapper classes initialization
        /// </summary>
        public static void ConfigureAll()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<DataLayerEntitiesToBusinessEntities>();
            });
        }
        #endregion
    }
}

using AutoMapper;
using Customer.BusinessEntities.Classification;
using Customer.BusinessEntities.Customer;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Mapping
{
    public class DataLayerEntitiesToBusinessEntities : Profile
    {
        #region Constructor
        public DataLayerEntitiesToBusinessEntities()
            : base("DataLayerEntitiesToBusinessEntities")
        {
            ConfigMap();

        }

        private void ConfigMap()
        {
            //CreateMap<Data.Domain.Benchmark, APPRYL.BusinessEntities.Common.Benchmark>().ReverseMap();

            CreateMap<CustomerDetailViewModel, Database.Models.Customer>()
                .ForMember(dest => dest.BusinessName, opts => opts.MapFrom(src => src.BusinessName))
                .ForMember(dest => dest.ClassificationId, opts => opts.MapFrom(src => src.ClassificationId))
                .ForMember(dest => dest.ClientTypeId, opts => opts.MapFrom(src => src.ClientTypeId))
                .ForMember(dest => dest.PrimaryContact, opts => opts.MapFrom(src => src.PrimaryContact))
                .ForMember(dest => dest.Salutation, opts => opts.MapFrom(src => src.Salutation))
                .ReverseMap();
        }
        #endregion

    }
}

using AutoMapper;
using Customer.Entities;
using Customer.ViewModel.Customer;
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
            CreateMap<CustomerDetailViewModel, Customer.Entities.Customer>()
               .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<CustomerDetailViewModel, Customer.Entities.CustomerImage>()
   .ForMember(dest => dest.Image, opts => opts.MapFrom(src => src.Image))
    .ReverseMap();


            CreateMap<CustomerDetailViewModel, Customer.Entities.CustomerDetail>()
                .ForMember(dest => dest.BusinessName, opts => opts.MapFrom(src => src.BusinessName))
                .ForMember(dest => dest.ClassificationId, opts => opts.MapFrom(src => src.ClassificationId))
                .ForMember(dest => dest.ClientTypeId, opts => opts.MapFrom(src => src.ClientTypeId))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.IsSecondaryAddressSame, opts => opts.MapFrom(src => src.IsSecondaryAddressSame))
                .ForMember(dest => dest.Phone, opts => opts.MapFrom(src => src.Phone))
                .ForMember(dest => dest.PrimaryAddress1, opts => opts.MapFrom(src => src.PrimaryAddress1))
                .ForMember(dest => dest.PrimaryAddress2, opts => opts.MapFrom(src => src.PrimaryAddress2))
                .ForMember(dest => dest.PrimaryAddress3, opts => opts.MapFrom(src => src.PrimaryAddress3))
                .ForMember(dest => dest.PrimaryCity, opts => opts.MapFrom(src => src.PrimaryCity))
                .ForMember(dest => dest.PrimaryContact, opts => opts.MapFrom(src => src.PrimaryContact))
                .ForMember(dest => dest.Salutation, opts => opts.MapFrom(src => src.Salutation))
                .ForMember(dest => dest.SecondaryAddress1, opts => opts.MapFrom(src => src.SecondaryAddress1))
                .ForMember(dest => dest.SecondaryAddress2, opts => opts.MapFrom(src => src.SecondaryAddress2))
                .ForMember(dest => dest.SecondaryAddress3, opts => opts.MapFrom(src => src.SecondaryAddress3))
                .ForMember(dest => dest.SecondaryCity, opts => opts.MapFrom(src => src.SecondaryCity))
                .ForMember(dest => dest.SecondaryCounty, opts => opts.MapFrom(src => src.SecondaryCounty))
                .ForMember(dest => dest.PrimaryContact, opts => opts.MapFrom(src => src.PrimaryContact))
                .ReverseMap();

        }
        #endregion

    }
}

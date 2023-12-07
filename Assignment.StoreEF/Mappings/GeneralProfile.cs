using AutoMapper;
using Assignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.StoreEF.Tables;

namespace Assignment.StoreEF.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, StoreEF.Tables.TblProduct>();


            //  CreateMap<IEnumerable<Product>, List<StoreEF.Tables.TblProduct>>().ConvertUsing<ProductDtoListMapper>();

            //  CreateMap< List < Domain.Models.Product > ,List <StoreEF.Tables.TblProduct>>();
            //    .ForMember(x=> x.CategoryName , opt=> opt.MapFrom( o=>  o.Category.Name)).ReverseMap();
            //   ;

            //  CreateMap <List<StoreEF.Tables.TblProduct>(), List<Domain.Models.Product>()>();
            //     .ForMember(x => x.for.CategoryName, opt => opt.MapFrom(o => o.Category.Name))
            //     ;
            // CreateMap<Domain.Models., ProductResponse>();
        }
    }

    //public class ProductDtoListMapper : ITypeConverter<List<StoreEF.Tables.TblProduct>, ProductDtoList>
    //{
    //    //public List<Order> Convert(OrderDtoList source, List<Order> destination, ResolutionContext context)
    //    //{
    //    //    return context.Mapper.Map<List<Order>>(source.Orders);
    //    //}
    //    public ProductDtoList Convert(List<TblProduct> source, ProductDtoList destination, ResolutionContext context)
    //    {
    //        return context.Mapper.Map<List<Order>>(source.Orders);
    //    }
    //}
}

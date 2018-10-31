using AutoMapper;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiService.Repository
{
    public class EntityMapper<TSource, TDestination> where TSource : class where TDestination : class
    {
        public EntityMapper()
        {
            Mapper.CreateMap<Models.Candidate, Tbl_Candidate>();
            Mapper.CreateMap<Tbl_Candidate, Models.Candidate>();
        }
        public TDestination Translate(TSource obj)
        {
            return Mapper.Map<TDestination>(obj);
        }
    }
}
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Entities;
using WorkFlow.Models;

namespace WorkFlow.Mapper
{
    public class AutoMappings:Profile
    {
        public AutoMappings()
        {
            CreateMap<WF, WFModel>().ReverseMap();
            CreateMap<WFStatus, WFStatusModel>().ReverseMap();
            CreateMap<WFStep, WFStepModel>().ReverseMap();
            CreateMap<WFTask, WFTaskModel>().ReverseMap();

        }
    }
}

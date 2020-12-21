using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.IRepos;

namespace WorkFlow.Supervisors
{
    public partial class Supervisor : ISupervisor
    {
        private readonly IMapper _mapper;
        private readonly IWFRepo _IWFRepo;
        private readonly IWFStatusRepo _IWFStatusRepo;
        private readonly IWFStepRepo _IWFStepRepo;
        private readonly IWFTaskRepo _IWFTaskRepo;
        public Supervisor(IMapper mapper, IWFRepo IWFRepo,
                          IWFStatusRepo IWFStatusRepo, IWFStepRepo IWFStepRepo
                          , IWFTaskRepo IWFTaskRepo)
        {
            _mapper = mapper;
            _IWFRepo = IWFRepo;
            _IWFStatusRepo = IWFStatusRepo;
            _IWFStepRepo = IWFStepRepo;
            _IWFTaskRepo = IWFTaskRepo;

        }

    }
}

﻿using AutoMapper;
using Grpc.Core;
using PlatformService.Data;

namespace PlatformService.AsyncDataServices.Grpc
{
    public class GrpcPlatformService : GrpcPlatform.GrpcPlatformBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;

        public GrpcPlatformService(IPlatformRepo repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override Task<PlatformReponse> GetAllPlatforms(GetAllRequest request, ServerCallContext context)
        {
            var response = new PlatformReponse();
            var platforms = _repository.GetAllPlatforms();
            foreach ( var platform in platforms )
            {
                response.Platform.Add(_mapper.Map<GrpcPlatformModel>(platform));
            }
            return Task.FromResult(response);
        }
    }
}
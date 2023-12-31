﻿using AutoMapper;
using MediatR;
using Logistics.Domain.Entities;

public class CreatePolicyHandler : IRequestHandler<CreatePolicyRequest, CreatePolicyResponse>
{
    // unit of work
    private readonly IUnitOfWork _unitOfWork;
    // repository camada de dados
    private readonly IPolicyRepository _policyRepository;
    // mapper
    private readonly IMapper _mapper;


    public CreatePolicyHandler(IUnitOfWork unitOfWork, IPolicyRepository policyRepository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _policyRepository = policyRepository;
        _mapper = mapper;
    }

    public async Task<CreatePolicyResponse> Handle(CreatePolicyRequest request, CancellationToken cancellationToken)
    {
        // onde de fato vamos mandar as informações para os nossos bds
        var policy = _mapper.Map<Policy>(request);

        _policyRepository.Create(policy);

        // aqui chama o nosso controle transacional
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreatePolicyResponse>(policy);
    }
}
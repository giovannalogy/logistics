using MediatR;
using Logistics.Domain.Entities;


public sealed record CreatePolicyRequest(
    AddressRegion AddressRegion,
    bool ApplyShipping,
    double? ValueShipping
    ) : IRequest<CreatePolicyResponse>;


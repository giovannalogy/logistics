using FluentValidation;

public sealed class CreatePolicyValidator : AbstractValidator<CreatePolicyRequest>
{
    public CreatePolicyValidator()
    {
        RuleFor(x => x.AddressRegion);
        RuleFor(x => x.ValueShipping);
    }
}

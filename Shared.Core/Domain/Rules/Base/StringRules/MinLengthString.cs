﻿using FluentValidation;
using Shared.Core.Domain.Errors.Base;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class MinLengthString : AbstractValidator<string>
{
    public MinLengthString(int minLength)
    {
        RuleFor(s => s)
            .MinimumLength(minLength)
            .WithErrorCode(StringErrors.NotReachMinLength);
    }
}
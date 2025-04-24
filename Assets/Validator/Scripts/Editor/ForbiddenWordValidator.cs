using System.Collections.Generic;
using Sirenix.OdinInspector.Editor.Validation;

[assembly: RegisterValidator(typeof(ForbiddenWordValidator))]

public class ForbiddenWordValidator : ValueValidator<string>
{
    private List<string> forbiddenWords = new List<string>
    {
        "Equilibrium",
        "Phosphorous",
        "Serendipity",
    };

    protected override void Validate(ValidationResult result)
    {
        if (forbiddenWords.Contains(this.Value))
        {
            result.AddError($"'{this.Value}' is a forbidden word, please change it!")
                .WithButton("Change", () =>
                {
                    this.Value = "Hello";
                });
            // result.Add(Sirenix.OdinInspector.ValidatorSeverity.Error, $"'{this.Value}' is a forbidden word, please change it!");
        }
    }
}
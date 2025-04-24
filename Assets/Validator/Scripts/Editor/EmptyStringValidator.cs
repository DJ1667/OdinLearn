using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Validation;

[assembly: RegisterValidationRule(typeof(EmptyStringValidator))]

public class EmptyStringValidator : ValueValidator<string>
{
    [EnumToggleButtons]
    public ValidatorSeverity Severity;

    protected override void Validate(ValidationResult result)
    {
        if (string.IsNullOrEmpty(this.Value))
        {
            // result.Add(Severity, "This string is empty! Are you sure that's correct?");

            // result.AddWarning("This string is empty! Are you sure that's correct?")
            // .WithFix(() => this.Value = "I'm not empty anymore");

            result.AddWarning("This string is empty! Are you sure that's correct?")
            .WithFix((FixArgs args) => this.Value = args.NewValue);
        }
    }

    private class FixArgs
    {
        public string NewValue = "Default";
    }
}
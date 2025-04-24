using Sirenix.OdinInspector.Editor.Validation;

[assembly: RegisterValidator(typeof(ForbiddenWordAttributeValidator))]

public class ForbiddenWordAttributeValidator : AttributeValidator<ForbiddenWordAttribute, string>
{
    protected override void Validate(ValidationResult result)
    {
        foreach (var forbiddenWord in this.Attribute.ForbiddenWords)
        {
            if (this.Value == forbiddenWord)
            {
                result.AddWarning($"'{this.Value}' is a forbidden word, please change it!");
                break;
            }
        }
    }
}
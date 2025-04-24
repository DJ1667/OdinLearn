using Sirenix.OdinInspector.Editor.Validation;

[assembly: RegisterValidator(typeof(VItemValidator))]

public class VItemValidator : RootObjectValidator<VItem>
{
    protected override void Validate(ValidationResult result)
    {
        if (string.IsNullOrEmpty(this.Value.Name))
        {
            result.AddWarning("请提供物品名称。");
        }
        if (string.IsNullOrEmpty(this.Value.Description))
        {
            result.AddWarning("请提供物品描述。");
        }
        if (this.Value.Damage > 100 || this.Value.Damage <= 0)
        {
            result.AddWarning("伤害值必须在0到100之间。");
        }
    }
}
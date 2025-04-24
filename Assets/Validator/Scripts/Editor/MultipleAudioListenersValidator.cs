using System.Linq;
using Sirenix.OdinInspector.Editor.Validation;
using UnityEngine;

[assembly: RegisterValidator(typeof(MultipleAudioListenersValidator))]

public class MultipleAudioListenersValidator : SceneValidator
{
    protected override void Validate(ValidationResult result)
    {
        var audioListeners = this.FindAllComponentsInSceneOfType<AudioListener>(includeInactive: false).ToList();
        var count = audioListeners.Count();

        if (count > 1)
        {
            ref var warining = ref result.AddWarning($"There are {count} active audio listeners in the scene. Please ensure there is always exactly one active audio listener in the scene.");
        }
    }
}
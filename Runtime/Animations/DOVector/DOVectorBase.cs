using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOVectorBase : DOAnimation
    {
        [field: SerializeField] public Vector3 StartValue { get; set; } = Vector3.zero;
        [field: SerializeField] public Vector3 EndValue { get; set; } = Vector3.zero;
        [field: SerializeField] public bool IsRelative { get; set; } = false;

        protected Vector3 GetEndValue(Vector3 position)
        {
            return IsRelative
            ? position + EndValue
            : EndValue;
        }
    }
}
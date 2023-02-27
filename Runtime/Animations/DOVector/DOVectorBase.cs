using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOVectorBase : DOAnimation
    {
        [field: SerializeField] public Vector3 StartValue { get; set; } = Vector3.zero;
        [field: SerializeField] public Vector3 EndValue { get; set; } = Vector3.zero;
        [field: SerializeField] public bool UseCustomStartValue { get; set; } = false;
        [field: SerializeField] public DOValueMode EndValueMode { get; set; } = DOValueMode.Absolute;

        protected Vector3 GetTweenEndValue(Vector3 startValue)
        {
            switch (EndValueMode)
            {
                default: return EndValue;
                case DOValueMode.Relative:
                {
                    return EndValue + startValue;
                }
            }
        }
    }
}
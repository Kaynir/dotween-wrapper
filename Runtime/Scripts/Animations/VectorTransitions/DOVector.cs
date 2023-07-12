using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOVector<T> : DOAnimation where T : Component
    {
        [SerializeField] protected T target = null;
        [SerializeField] private Vector3 startValue = Vector3.zero;
        [SerializeField] private Vector3 endValue = Vector3.zero;
        [SerializeField] private bool useCustomStartValue = false;
        [SerializeField] private DOValueMode endValueMode = DOValueMode.Absolute;

        protected abstract Vector3 GetTargetStartValue(T target);

        protected Vector3 GetStartValue()
        {
            return useCustomStartValue
            ? startValue
            : GetTargetStartValue(target);
        }

        protected Vector3 GetEndValue()
        {
            switch (endValueMode)
            {
                default: return endValue;
                case DOValueMode.Relative:
                {
                    return endValue + GetStartValue();
                }
            }
        }
    }
}
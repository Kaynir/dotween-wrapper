using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOVectorBase : DOAnimation
    {
        [SerializeField] protected Vector3 _endValue = Vector3.zero;
        [SerializeField] protected bool _isFromValue = false;
        [SerializeField] protected bool _isRelative = false;

        protected Vector3 GetRelative(Vector3 position)
        {
            return _isRelative
            ? position + _endValue
            : _endValue;
        }
    }
}
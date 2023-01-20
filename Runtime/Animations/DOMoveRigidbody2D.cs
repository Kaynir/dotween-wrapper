using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveRigidbody2D : DOVectorBase
    {
        [SerializeField] private Rigidbody2D _target = null;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOMove(_endValue, Duration).From(true, _isRelative)
            : _target.DOMove(GetRelative(_target.position), Duration);
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOScale : DOVectorBase
    {
        [SerializeField] private Transform _target = null;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOScale(_endValue, Duration).From(true, _isRelative)
            : _target.DOScale(GetRelative(_target.localScale), Duration);
        }
    }
}
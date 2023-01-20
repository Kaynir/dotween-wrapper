using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveAnchored : DOVectorBase
    {
        [SerializeField] private RectTransform _target = null;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOAnchorPos3D(_endValue, Duration).From(true, _isRelative)
            : _target.DOAnchorPos3D(GetRelative(_target.anchoredPosition3D), Duration);
        }
    }
}
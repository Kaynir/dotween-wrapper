using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveAnchored : DOVectorBase
    {
        [SerializeField] private RectTransform _target = null;

        protected override Tween CreateTween(float duration)
        {
            if (UseCustomStartValue) _target.anchoredPosition3D = StartValue;
            return _target.DOAnchorPos3D(GetTweenEndValue(_target.anchoredPosition3D), duration);
        }
    }
}
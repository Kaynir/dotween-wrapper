using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveAnchored : DOVectorBase
    {
        [SerializeField] private RectTransform _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOAnchorPos3D(GetEndValue(_target.anchoredPosition3D), duration)
                          .From(StartValue);
        }
    }
}
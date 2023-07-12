using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveAnchored : DOVector<RectTransform>
    {
        protected override Tween CreateTween(float duration)
        {
            return target.DOAnchorPos3D(GetEndValue(), duration)
                         .From(GetStartValue());
        }

        protected override Vector3 GetTargetStartValue(RectTransform target)
        {
            return target.anchoredPosition3D;
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOGroupAlpha : DOAlpha
    {
        [SerializeField] private CanvasGroup target = null;

        protected override Tween CreateTween(float duration)
        {
            return target.DOFade(endValue, duration)
                         .From(startValue);
        }
    }
}
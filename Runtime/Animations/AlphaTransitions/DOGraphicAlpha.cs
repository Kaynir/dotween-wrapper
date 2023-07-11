using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicAlpha : DOAlpha
    {
        [SerializeField] private Graphic target = null;

        protected override Tween CreateTween(float duration)
        {
            return target.DOFade(endValue, duration)
                         .From(startValue);
        }
    }
}
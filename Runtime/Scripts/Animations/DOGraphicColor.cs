using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicColor : DOAnimation
    {
        [SerializeField] private Graphic target = null;
        [SerializeField] private Color startValue = Color.white;
        [SerializeField] private Color endValue = Color.white;

        protected override Tween CreateTween(float duration)
        {
            return target.DOColor(endValue, duration)
                         .From(startValue);
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOGroupAlpha : DOAlphaBase
    {
        [SerializeField] private CanvasGroup _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOFade(EndValue, duration)
                          .From(StartValue);
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOGroupAlpha : DOAlphaBase
    {
        [SerializeField] private CanvasGroup _target = null;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOFade(_endValue, Duration).From()
            : _target.DOFade(_endValue, Duration);
        }
    }
}
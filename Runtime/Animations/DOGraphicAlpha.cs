using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicAlpha : DOAlphaBase
    {
        [SerializeField] private Graphic _target = null;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOFade(_endValue, Duration).From()
            : _target.DOFade(_endValue, Duration);
        }
    }
}
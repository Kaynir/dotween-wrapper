using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicAlpha : DOAlphaBase
    {
        [SerializeField] private Graphic _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOFade(EndValue, duration)
                          .From(StartValue);
        }
    }
}
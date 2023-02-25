using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicColor : DOAnimation
    {
        [SerializeField] private Graphic _target = null;
        
        [field: SerializeField] public Color StartValue { get; set; } = Color.white;
        [field: SerializeField] public Color EndValue { get; set; } = Color.white;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOColor(EndValue, duration)
                          .From(StartValue);
        }
    }
}
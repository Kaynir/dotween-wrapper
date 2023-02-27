using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOScale : DOVectorBase
    {
        [SerializeField] private Transform _target = null;

        protected override Tween CreateTween(float duration)
        {
            if (UseCustomStartValue) _target.localScale = StartValue;
            return _target.DOScale(GetTweenEndValue(_target.localScale), duration);
        }
    }
}
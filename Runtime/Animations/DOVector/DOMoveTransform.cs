using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveTransform : DOVectorBase
    {
        [SerializeField] private Transform _target = null;

        protected override Tween CreateTween(float duration)
        {
            if (UseCustomStartValue) _target.position = StartValue;
            return _target.DOMove(GetTweenEndValue(_target.position), duration);
        }
    }
}
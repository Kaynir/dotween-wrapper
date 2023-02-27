using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveRigidbody2D : DOVectorBase
    {
        [SerializeField] private Rigidbody2D _target = null;

        protected override Tween CreateTween(float duration)
        {
            if (UseCustomStartValue) _target.position = StartValue;
            return _target.DOMove(GetTweenEndValue(_target.position), duration);
        }
    }
}
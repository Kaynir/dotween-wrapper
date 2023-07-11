using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveRigidbody2D : DOVector<Rigidbody2D>
    {
        protected override Tween CreateTween(float duration)
        {
            return target.DOMove(GetEndValue(), duration)
                         .From(GetStartValue());
        }

        protected override Vector3 GetTargetStartValue(Rigidbody2D target)
        {
            return target.position;
        }
    }
}
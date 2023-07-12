using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveTransform : DOVector<Transform>
    {
        protected override Tween CreateTween(float duration)
        {
            return target.DOMove(GetEndValue(), duration)
                         .From(GetStartValue());
        }

        protected override Vector3 GetTargetStartValue(Transform target)
        {
            return target.position;
        }
    }
}
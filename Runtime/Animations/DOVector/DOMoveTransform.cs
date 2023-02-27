using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveTransform : DOVectorBase
    {
        [SerializeField] private Transform _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOMove(GetEndValue(_target.position), duration)
                          .From(StartValue);
        }
    }
}
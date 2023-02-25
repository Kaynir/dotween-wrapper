using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOMoveRigidbody2D : DOVectorBase
    {
        [SerializeField] private Rigidbody2D _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOMove(GetEndValue(_target.position), duration)
                          .From(StartValue);
        }
    }
}
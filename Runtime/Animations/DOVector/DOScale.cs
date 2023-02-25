using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOScale : DOVectorBase
    {
        [SerializeField] private Transform _target = null;

        protected override Tween CreateTween(float duration)
        {
            return _target.DOScale(GetEndValue(_target.localScale), duration)
                          .From(StartValue);
        }
    }
}
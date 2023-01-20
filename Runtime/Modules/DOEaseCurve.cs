using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public class DOEaseCurve : DOModule
    {
        [SerializeField] private AnimationCurve _curve = AnimationCurve.Linear(0, 0, 1, 1);

        public override void Apply(Tween tween)
        {
            tween.SetEase(_curve);
        }
    }
}
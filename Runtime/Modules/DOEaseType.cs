using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public class DOEaseType : DOModule
    {
        [SerializeField] private Ease _ease = Ease.Linear;

        public override void Apply(Tween tween)
        {
            tween.SetEase(_ease);
        }
    }
}
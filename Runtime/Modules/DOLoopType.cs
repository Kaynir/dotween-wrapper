using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public class DOLoopType : DOModule
    {
        [SerializeField, Min(-1)] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public override void Apply(Tween tween)
        {
            tween.SetLoops(_loops, _loopType);
        }
    }
}
using System;
using DG.Tweening;
using Kaynir.Tweening.Animations;
using UnityEngine;

namespace Kaynir.Tweening
{
    [Serializable]
    public class AnimationData
    {
        [SerializeField] private DOAnimation _animation;
        [SerializeField] private bool _join = false;

        public Sequence ApplySequence(Sequence sequence)
        {
            return _join 
            ? sequence.Join(_animation.GetTween())
            : sequence.Append(_animation.GetTween());
        }
    }
}
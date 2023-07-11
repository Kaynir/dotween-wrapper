using System;
using DG.Tweening;
using Kaynir.Tweening.Animations;
using UnityEngine;

namespace Kaynir.Tweening
{
    [Serializable]
    public class DOAnimatorClip
    {
        [SerializeField] private DOAnimation animation = null;
        [SerializeField] private bool join = false;

        public Sequence Append(Sequence sequence)
        {
            return join
            ? sequence.Join(animation.GetTween())
            : sequence.Append(animation.GetTween());
        }
    }
}
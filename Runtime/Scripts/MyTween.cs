using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public abstract class MyTween : MonoBehaviour
    {
        [SerializeField] private Ease _ease = Ease.OutQuad;
        [SerializeField, Min(0f)] private float _duration = 1f;
        [SerializeField, Min(0f)] private float _delay = 0f;
        [SerializeField, Min(-1)] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public float Duration => _duration;

        public Tween Tween => CreateTween().SetDelay(_delay)
                                           .SetEase(_ease)
                                           .SetLoops(_loops, _loopType);

        protected abstract Tween CreateTween();
    }
}
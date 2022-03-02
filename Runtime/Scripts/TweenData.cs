using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public abstract class TweenData<T> where T : Component
    {
        [SerializeField] private T _target = default;
        [SerializeField] protected float _duration = 1f;
        [SerializeField] private float _delay = 0f;
        [SerializeField] private Ease _ease = Ease.Linear;
        [SerializeField] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public Tween GetTween(T target)
        {
            return CreateTween(target).SetDelay(_delay)
                                      .SetLoops(_loops, _loopType)
                                      .SetEase(_ease);
        }

        public Tween GetTween() => GetTween(_target);

        protected abstract Tween CreateTween(T target);
    }
}
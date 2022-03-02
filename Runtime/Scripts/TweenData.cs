using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public abstract class TweenData<T> where T : Component
    {
        [SerializeField] private T _target = default;
        [SerializeField] protected float _duration = 1f;
        [SerializeField] private Ease _ease = Ease.Linear;
        [SerializeField] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public Tween Tween => CreateTween(_target).SetLoops(_loops, _loopType)
                                                  .SetEase(_ease);

        protected abstract Tween CreateTween(T target);
    }
}
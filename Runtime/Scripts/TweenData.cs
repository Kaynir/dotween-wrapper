using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public abstract class TweenData<T> : ScriptableObject where T : Component
    {
        [SerializeField, Min(0f)] protected float _duration = 1f;
        [SerializeField, Min(0f)] private float _delay = 0f;
        [SerializeField, Min(-1)] private int _loops = 0;
        [SerializeField] private Ease _ease = Ease.Linear;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public void PlayTween(T target) => GetTween(target).SetAutoKill(true).Play();

        public Tween GetTween(T target) => CreateTween(target).SetDelay(_delay).SetLoops(_loops, _loopType).SetEase(_ease);

        protected abstract Tween CreateTween(T target);
    }
}
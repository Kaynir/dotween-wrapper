using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public abstract class TweenData<T> : ScriptableObject where T : Component
    {
        [SerializeField] protected float _duration = 1f;
        [SerializeField] private Ease _ease = Ease.Linear;

        public Tween GetTween(T target) => CreateTween(target).SetEase(_ease);

        protected abstract Tween CreateTween(T target);
    }
}
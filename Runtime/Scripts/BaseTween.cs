using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public abstract class BaseTween : MonoBehaviour
    {
        [SerializeField] protected float _duration = 1f;
        [SerializeField] private float _delay = 0f;
        [SerializeField] private int _loops = 0;
        [SerializeField] private Ease _ease = Ease.Linear;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        private Tween _tween;

        public Tween GetTween()
        {
            if (_tween == null)
            {
                _tween = CreateTween().SetAutoKill(false).Pause();
                _tween.SetDelay(_delay).SetLoops(_loops, _loopType).SetEase(_ease);
            }

            return _tween;
        }

        [ContextMenu("Restart")]
        public void Restart() => GetTween().Restart();

        [ContextMenu("Play Forward")]
        public void PlayForward() => GetTween().PlayForward();

        [ContextMenu("Play Backwards")]
        public void PlayBackwards() => GetTween().PlayBackwards();

        protected abstract Tween CreateTween();
    }
}
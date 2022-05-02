using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public abstract class MyTween : MonoBehaviour
    {
        [Header("Base Settings:")]
        [SerializeField] private bool _autoPlay = false;
        [SerializeField] private Ease _ease = Ease.Unset;
        [SerializeField, Min(0f)] private float _duration = 1f;
        [SerializeField, Min(0f)] private float _delay = 0f;
        [SerializeField, Min(-1)] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;
        [SerializeField] private bool _timeScaleIndependant = false;
        [SerializeField] private UpdateType _updateType = UpdateType.Normal;

        public float Duration => _duration;
        public Tween Tween => GetTween();

        private Tween _tween;

        protected virtual void OnEnable()
        {
            if (_autoPlay) Restart();
        }

        protected virtual void OnDestroy() => _tween?.Kill();

        [ContextMenu("Restart")]
        public void Restart() => Tween.Restart();

        private Tween GetTween()
        {
            if (_tween == null)
            {
                _tween = CreateTween();
                _tween.Pause();
                _tween.SetAutoKill(false);
                _tween.SetDelay(_delay);
                _tween.SetEase(_ease);
                _tween.SetLoops(_loops, _loopType);
                _tween.SetUpdate(_updateType, _timeScaleIndependant);
            }

            return _tween;
        }

        protected abstract Tween CreateTween();
    }
}
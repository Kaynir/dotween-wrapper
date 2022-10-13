using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening
{
    public abstract class DOAnimation : MonoBehaviour
    {
        [SerializeField] private float _duration = .5f;
        [SerializeField] private Ease _ease = Ease.Linear;
        [Header("Loop Settings:")]
        [SerializeField, Min(0)] private int _loops = 0;
        [SerializeField] private LoopType _loopType = LoopType.Restart;

        public float Duration => _duration;

        public Tween GetAnimation()
        {
            Tween tween = CreateAnimation();

            tween.SetEase(_ease);
            tween.SetLoops(_loops, _loopType);

            return tween;
        }

        protected abstract Tween CreateAnimation();
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOPositionShake : DOAnimation
    {
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _strength = Vector3.zero;
        [SerializeField] private int _vibrato = 10;
        [SerializeField, Range(0f, 180f)] private float _randomness = 90;
        [SerializeField] private ShakeRandomnessMode _randomnessMode = ShakeRandomnessMode.Full;
        [SerializeField] private bool _snapping = false;
        [SerializeField] private bool _fadeOut = true;

        protected override Tween CreateTween()
        {
            return _target.DOShakePosition(
                Duration,
                _strength,
                _vibrato,
                _randomness,
                _snapping,
                _fadeOut,
                _randomnessMode
            );
        }
    }
}
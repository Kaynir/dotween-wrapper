using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public class DOPositionShake : DOAnimation
    {
        [SerializeField] private Transform target = null;
        [SerializeField] private Vector3 strength = Vector3.zero;
        [SerializeField] private int vibrato = 10;
        [SerializeField, Range(0f, 180f)] private float randomness = 90;
        [SerializeField] private ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full;
        [SerializeField] private bool snapping = false;
        [SerializeField] private bool fadeOut = true;

        protected override Tween CreateTween(float duration)
        {
            return target.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeOut, randomnessMode);
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class DOPositionShake : DOAnimation
    {
        [Header("Shake Settings:")]
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _strength = Vector3.zero;
        [SerializeField] private int _vibrato = 10;
        [SerializeField, Range(0f, 180f)] private float _randomness = 90;
        [SerializeField] private bool _snapping = false;
        [SerializeField] private bool _fadeOut = true;

        protected override Tween CreateAnimation()
        {
            return _target.DOShakePosition(Duration, _strength, _vibrato, _randomness, _snapping, _fadeOut);
        }
    }
}
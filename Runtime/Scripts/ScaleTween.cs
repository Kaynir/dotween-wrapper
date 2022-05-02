using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class ScaleTween : MyTween
    {
        [Header("Scale Settings:")]
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _endScale = Vector3.one;

        protected override Tween CreateTween() => _target.DOScale(_endScale, Duration);
    }
}
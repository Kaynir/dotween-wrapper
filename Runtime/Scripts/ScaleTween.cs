using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class ScaleTween : MyTween
    {
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _endScale = Vector3.one;

        protected override Tween CreateTween() => _target.DOScale(_endScale, Duration);
    }
}
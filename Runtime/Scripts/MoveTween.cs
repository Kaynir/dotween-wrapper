using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class MoveTween : MyTween
    {
        [Header("Move Settings:")]
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector2 _endPosition = Vector2.zero;

        protected override Tween CreateTween() => _target.DOMove(_endPosition, Duration);
    }
}
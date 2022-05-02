using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class MoveRectTween : MyTween
    {
        [Header("Move Settings:")]
        [SerializeField] private RectTransform _target = null;
        [SerializeField] private Vector2 _endPosition = Vector2.zero;

        protected override Tween CreateTween() => _target.DOAnchorPos(_endPosition, Duration);
    }
}
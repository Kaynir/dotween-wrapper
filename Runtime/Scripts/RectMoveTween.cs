using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class RectMoveTween : TweenData<RectTransform>
    {
        [SerializeField] private Vector2 _endPosition = Vector2.zero;

        protected override Tween CreateTween(RectTransform target) => target.DOAnchorPos(_endPosition, _duration);
    }
}
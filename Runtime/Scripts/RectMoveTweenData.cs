using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public class RectMoveTweenData : TweenData<RectTransform>
    {
        [SerializeField] private Vector2 _anchoredPosition = Vector2.zero;

        protected override Tween CreateTween(RectTransform target)
        {
            return target.DOAnchorPos(_anchoredPosition, _duration);
        }
    }
}
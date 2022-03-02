using DG.Tweening;
using System;
using UnityEngine;

namespace KaynirGames.Tweening
{
    [Serializable]
    public class RectMoveTweenData : TweenData<RectTransform>
    {
        [SerializeField] private Vector2 _anchoredPosition = Vector2.zero;

        protected override Tween CreateTween(RectTransform target)
        {
            return target.DOAnchorPos(_anchoredPosition, _duration);
        }
    }
}
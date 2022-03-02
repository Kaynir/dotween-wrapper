using DG.Tweening;
using System;
using UnityEngine;

namespace KaynirGames.Tweening
{
    [Serializable]
    public class CanvasFadeTweenData : TweenData<CanvasGroup>
    {
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        public float Alpha => _alpha;

        protected override Tween CreateTween(CanvasGroup target)
        {
            return target.DOFade(_alpha, _duration);
        }
    }
}
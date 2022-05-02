using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class CanvasFadeTween : TweenData<CanvasGroup>
    {
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        protected override Tween CreateTween(CanvasGroup target) => target.DOFade(_alpha, _duration);
    }
}
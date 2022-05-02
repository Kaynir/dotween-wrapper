using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class CanvasFadeTween : MyTween
    {
        [Header("Fade Settings:")]
        [SerializeField] private CanvasGroup _target = null;
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        protected override Tween CreateTween() => _target.DOFade(_alpha, Duration);
    }
}
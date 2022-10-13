using DG.Tweening;
using System;
using UnityEngine;

namespace Kaynir.Tweening
{
    public class DOGroupAlpha : DOAnimation
    {
        [Header("Fade Settings:")]
        [SerializeField] private CanvasGroup _target = null;
        [SerializeField, Range(0f, 1f)] private float _startAlpha = 0f;
        [SerializeField, Range(0f, 1f)] private float _endAlpha = 1f;

        protected override Tween CreateAnimation()
        {
            _target.alpha = _startAlpha;
            return _target.DOFade(_endAlpha, Duration);
        }
    }
}
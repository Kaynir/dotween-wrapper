using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening
{
    public class DOGraphicAlpha : DOAnimation
    {
        [Header("Fade Settings:")]
        [SerializeField] private Graphic _target = null;
        [SerializeField, Range(0f, 1f)] private float _startAlpha = 0f;
        [SerializeField, Range(0f, 1f)] private float _endAlpha = 1f;

        protected override Tween CreateAnimation()
        {
            Color startColor = _target.color;
            startColor.a = _startAlpha;

            _target.color = startColor;
            return _target.DOFade(_endAlpha, Duration);
        }
    }
}
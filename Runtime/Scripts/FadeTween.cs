using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CozyDragon.Tweening
{
    public class FadeTween : MyTween
    {
        [SerializeField] private Graphic _target = null;
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        protected override Tween CreateTween() => _target.DOFade(_alpha, Duration);
    }
}
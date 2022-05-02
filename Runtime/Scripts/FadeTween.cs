using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CozyDragon.Tweening
{
    public class FadeTween : TweenData<Graphic>
    {
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        protected override Tween CreateTween(Graphic target) => target.DOFade(_alpha, _duration);
    }
}
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace KaynirGames.Tweening
{
    public class FadeTweenData : TweenData<Graphic>
    {
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        protected override Tween CreateTween(Graphic target)
        {
            return target.DOFade(_alpha, _duration);
        }
    }
}
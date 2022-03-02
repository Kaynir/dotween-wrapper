using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace KaynirGames.Tweening
{
    [Serializable]
    public class FadeTweenData : TweenData<Graphic>
    {
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        public float Alpha => _alpha;

        protected override Tween CreateTween(Graphic target)
        {
            return target.DOFade(_alpha, _duration);
        }
    }
}
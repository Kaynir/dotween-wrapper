using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public class ScaleTweenData : TweenData<Transform>
    {
        [SerializeField] private float _endScale = 1.25f;

        protected override Tween CreateTween(Transform target)
        {
            return target.DOScale(_endScale, _duration);
        }
    }
}
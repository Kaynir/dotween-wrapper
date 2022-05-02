using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class ScaleTween : TweenData<Transform>
    {
        [SerializeField] private Vector3 _endScale = Vector3.one;

        protected override Tween CreateTween(Transform target) => target.DOScale(_endScale, _duration);
    }
}
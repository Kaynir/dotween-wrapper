using DG.Tweening;
using System;
using UnityEngine;

namespace KaynirGames.Tweening
{
    [Serializable]
    public class ScaleTween : BaseTween<Transform>
    {
        [SerializeField] private float _endScale = 1.25f;

        protected override Tween CreateTween(Transform target)
        {
            return target.DOScale(_endScale, _duration);
        }
    }
}
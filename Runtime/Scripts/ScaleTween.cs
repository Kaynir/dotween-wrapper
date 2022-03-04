using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public class ScaleTween : BaseTween
    {
        [SerializeField] private Transform _target = null;
        [SerializeField] private float _endScale = 1.25f;

        protected override Tween CreateTween()
        {
            return _target.DOScale(_endScale, _duration);
        }
    }
}
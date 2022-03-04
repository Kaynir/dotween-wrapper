using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace KaynirGames.Tweening
{
    public class FadeTween : BaseTween
    {
        [SerializeField] private Graphic _target = null;
        [SerializeField, Range(0f, 1f)] private float _alpha = 0f;

        public float Alpha => _alpha;

        protected override Tween CreateTween()
        {
            return _target.DOFade(_alpha, _duration);
        }
    }
}
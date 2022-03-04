using DG.Tweening;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public class RectMoveTween : BaseTween
    {
        [SerializeField] private RectTransform _target = null;
        [SerializeField] private Vector2 _offset = Vector2.zero;

        protected override Tween CreateTween()
        {
            return _target.DOAnchorPos(_target.anchoredPosition + _offset, _duration);
        }
    }
}
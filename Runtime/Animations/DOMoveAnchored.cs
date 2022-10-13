using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening
{
    public class DOMoveAnchored : DOAnimation
    {
        [Header("Move Settings:")]
        [SerializeField] private RectTransform _target = null;
        [SerializeField] private Vector2 _startPosition = Vector2.zero;
        [SerializeField] private Vector2 _endPosition = Vector2.zero;
        [SerializeField] private bool _useCustomStartPosition = false;
        [SerializeField] private bool _useEndPositionAsOffset = false;

        protected override Tween CreateAnimation()
        {
            if (_useCustomStartPosition)
            {
                _target.anchoredPosition = _startPosition;
            }

            return _target.DOAnchorPos(GetEndPosition(), Duration);
        }

        private Vector2 GetEndPosition()
        {
            return _useEndPositionAsOffset
                ? _target.anchoredPosition + _endPosition
                : _endPosition;
        }
    }
}
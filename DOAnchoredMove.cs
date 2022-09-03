using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class DOAnchoredMove : DOAnimation
    {
        [Header("Move Settings:")]
        [SerializeField] private RectTransform _target = null;
        [SerializeField] private Vector2 _startPosition = Vector2.zero;
        [SerializeField] private Vector2 _endPosition = Vector2.zero;
        [SerializeField] private bool _useCustomStartPosition = false;
        [SerializeField] private bool _useEndPositionAsOffset = false;

        protected override Tween CreateAnimation()
        {
            _target.anchoredPosition = _startPosition;
            return _target.DOAnchorPos(GetEndPosition(), Duration);
        }

        private Vector2 GetEndPosition()
        {
            return _useEndPositionAsOffset
                ? _startPosition + _endPosition
                : _endPosition;
        }

        private void OnValidate()
        {
            if (_useCustomStartPosition) return;
            _startPosition = _target.anchoredPosition;
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening
{
    public class DOMoveRigidbody2D : DOAnimation
    {
        [Header("Move Settings:")]
        [SerializeField] private Rigidbody2D _target = null;
        [SerializeField] private Vector2 _startPosition = Vector2.zero;
        [SerializeField] private Vector2 _endPosition = Vector2.zero;
        [SerializeField] private bool _useCustomStartPosition = false;
        [SerializeField] private bool _useEndPositionAsOffset = false;

        protected override Tween CreateAnimation()
        {
            if (_useCustomStartPosition)
            {
                _target.position = _startPosition;
            }

            return _target.DOMove(GetEndPosition(), Duration);
        }

        private Vector2 GetEndPosition()
        {
            return _useEndPositionAsOffset
                ? _target.position + _endPosition
                : _endPosition;
        }
    }
}
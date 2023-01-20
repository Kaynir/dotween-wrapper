using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Kaynir.Tweening.Animations
{
    public class DOGraphicColor : DOAnimation
    {
        [SerializeField] private Graphic _target = null;
        [SerializeField] private Color _endValue = Color.white;
        [SerializeField] private bool _isFromValue = false;

        protected override Tween CreateTween()
        {
            return _isFromValue
            ? _target.DOColor(_endValue, Duration).From()
            : _target.DOColor(_endValue, Duration);
        }
    }
}
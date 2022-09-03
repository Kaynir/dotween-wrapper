using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class DOScale : DOAnimation
    {
        [Header("Scale Settings:")]
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _startScale = Vector3.zero;
        [SerializeField] private Vector3 _endScale = Vector3.one;

        protected override Tween CreateAnimation()
        {
            _target.localScale = _startScale;
            return _target.DOScale(_endScale, Duration);
        }
    }
}
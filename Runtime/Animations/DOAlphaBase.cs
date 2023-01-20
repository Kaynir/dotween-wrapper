using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAlphaBase : DOAnimation
    {
        [SerializeField, Range(0f, 1f)] protected float _endValue = 0f;
        [SerializeField] protected bool _isFromValue = false;
    }
}
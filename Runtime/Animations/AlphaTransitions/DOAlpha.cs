using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAlpha : DOAnimation
    {
        [SerializeField, Range(0f, 1f)] protected float startValue = 1f;
        [SerializeField, Range(0f, 1f)] protected float endValue = 0f;
    }
}
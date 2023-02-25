using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAlphaBase : DOAnimation
    {
        [field: SerializeField, Range(0f, 1f)] public float StartValue { get; set; } = 1f;
        [field: SerializeField, Range(0f, 1f)] public float EndValue { get; set; } = 0f;
    }
}
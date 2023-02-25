using System.Collections.Generic;
using DG.Tweening;
using Kaynir.Tweening.Modules;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAnimation : MonoBehaviour
    {
        [field: SerializeField] public float Duration { get; set; } = .5f;
        [SerializeField] private List<DOModule> _modules = new List<DOModule>();

        public Tween GetTween()
        {
            Tween tween = CreateTween(Duration);

            _modules.ForEach(m => m.Apply(tween));

            return tween;
        }

        [ContextMenu("Play")]
        public void Play() => GetTween().Play();

        protected abstract Tween CreateTween(float duration);
    }
}
using System.Collections.Generic;
using DG.Tweening;
using Kaynir.Tweening.Events;
using Kaynir.Tweening.Modules;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAnimation : MonoBehaviour
    {
        [SerializeField] private float duration = .5f;
        [SerializeField] private List<DOModule> modules = new List<DOModule>();
        [SerializeField] private List<DOEvent> events = new List<DOEvent>();

        public float Duration => duration;

        public Tween GetTween()
        {
            Tween tween = CreateTween(duration);

            modules.ForEach(m => m.Apply(tween));
            events.ForEach(e => e.SetCallback(tween));

            return tween;
        }

        [ContextMenu("Play")]
        public void Play() => GetTween().Play();

        protected abstract Tween CreateTween(float duration);
    }
}
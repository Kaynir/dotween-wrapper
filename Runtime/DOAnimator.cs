using DG.Tweening;
using Kaynir.Tweening.Events;
using Kaynir.Tweening.Modules;
using System.Collections.Generic;
using UnityEngine;

namespace Kaynir.Tweening
{
    public class DOAnimator : MonoBehaviour
    {
        [SerializeField] private List<DOAnimatorClip> animations = new List<DOAnimatorClip>();
        [SerializeField] private List<DOModule> modules = new List<DOModule>();
        [SerializeField] private List<DOEvent> events = new List<DOEvent>();
        [SerializeField] private bool playOnStart = false;

        public Sequence Sequence => sequence ?? CreateSequence();

        private Sequence sequence;

        private void Start()
        {
            if (!playOnStart) return;
            Play();
        }

        private void OnDestroy() => sequence?.Kill();

        public Sequence CreateSequence()
        {
            sequence?.Kill();
            sequence = DOTween.Sequence();
            sequence.SetAutoKill(false);

            animations.ForEach(a => a.Append(sequence));
            modules.ForEach(m => m.Apply(sequence));
            events.ForEach(e => e.SetCallback(sequence));

            return sequence;
        }

        public void Play()
        {
            if (Sequence.IsComplete())
            {
                Sequence.PlayBackwards();
                return;
            }

            Sequence.PlayForward();
        }

        public void Restart() => Sequence.Restart();
        public void Complete() => Sequence.Complete(true);
        public void Rewind() => Sequence.Rewind();
    }
}
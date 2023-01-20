using DG.Tweening;
using Kaynir.Tweening.Modules;
using System.Collections.Generic;
using UnityEngine;

namespace Kaynir.Tweening
{
    public class DOAnimator : MonoBehaviour
    {
        [SerializeField] private List<AnimationData> _animations = new List<AnimationData>();
        [SerializeField] private List<DOModule> _modules = new List<DOModule>();
        [SerializeField] private bool _autoPlay = false;

        public Sequence Sequence { get; private set; }

        private void Awake() => CreateSequence();

        private void OnDestroy() => Sequence?.Kill();

        public void CreateSequence()
        {
            if (Sequence != null) Sequence.Kill();

            Sequence = DOTween.Sequence();
            Sequence.SetAutoKill(false);

            _animations.ForEach(a => a.ApplySequence(Sequence));
            _modules.ForEach(m => m.Apply(Sequence));

            if (_autoPlay) Play();
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
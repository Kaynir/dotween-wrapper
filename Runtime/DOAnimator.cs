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
        [SerializeField] private bool _playOnStart = false;

        public Sequence Sequence
        {
            get
            {
                if (_sequence == null) CreateSequence();
                return _sequence;
            }
        }

        private Sequence _sequence;

        private void Start()
        {
            if (_playOnStart) Play();
        }

        private void OnDestroy() => _sequence?.Kill();

        public void CreateSequence()
        {
            _sequence?.Kill();
            _sequence = DOTween.Sequence();
            _sequence.SetAutoKill(false);

            _animations.ForEach(a => a.ApplySequence(Sequence));
            _modules.ForEach(m => m.Apply(Sequence));
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
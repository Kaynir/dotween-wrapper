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

        private Sequence _sequence;

        private void Start()
        {
            if (_playOnStart) Play();
        }

        private void OnDestroy() => _sequence?.Kill();

        public Sequence GetSequence()
        {
            if (_sequence == null) CreateSequence();
            return _sequence;
        }

        public void Play()
        {
            if (GetSequence().IsComplete())
            {
                GetSequence().PlayBackwards();
                return;
            }

            GetSequence().PlayForward();
        }

        public void Restart() => GetSequence().Restart();
        public void Complete() => GetSequence().Complete(true);
        public void Rewind() => GetSequence().Rewind();

        private void CreateSequence()
        {
            _sequence = DOTween.Sequence();
            _sequence.SetAutoKill(false);

            _animations.ForEach(a => a.ApplySequence(GetSequence()));
            _modules.ForEach(m => m.Apply(GetSequence()));
        }
    }
}
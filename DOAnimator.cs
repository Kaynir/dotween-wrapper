using DG.Tweening;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CozyDragon.Tweening
{
    public class DOAnimator : MonoBehaviour
    {
        [SerializeField] private List<AnimationData> _animations = new List<AnimationData>();
        [SerializeField] private bool _autoPlay = false;
        [SerializeField] private LoopType _loopType = LoopType.Restart;
        [SerializeField, Min(-1)] private int _loops = 0;
        [SerializeField] private UpdateType _updateType = UpdateType.Normal;
        [SerializeField] private bool _ignoreTimeScale = false;
        [SerializeField] private UnityEvent _onStarted = new UnityEvent();
        [SerializeField] private UnityEvent _onCompleted = new UnityEvent();
        [SerializeField] private UnityEvent _onRewinded = new UnityEvent();

        public UnityEvent OnCompleted => _onCompleted;
        public UnityEvent OnStarted => _onStarted;
        public UnityEvent OnRewinded => _onRewinded;

        public Sequence Sequence { get; private set; }

        private void Awake() => CreateSequence();

        private void OnDestroy() => Sequence.Kill();

        public void CreateSequence()
        {
            if (Sequence != null) Sequence.Kill();

            Sequence = DOTween.Sequence();

            if (!_autoPlay) Sequence.Pause();

            Sequence.SetAutoKill(false);
            Sequence.OnPlay(() => _onStarted.Invoke());

            _animations.ForEach(a => a.AddToSequence(Sequence));

            Sequence.SetUpdate(_updateType, _ignoreTimeScale);
            Sequence.SetLoops(_loops, _loopType);
            Sequence.OnComplete(() => _onCompleted.Invoke());
            Sequence.OnRewind(() => _onRewinded.Invoke());
        }

        [ContextMenu("Play")]
        public void Play()
        {
            if (Sequence.IsComplete())
            {
                Sequence.PlayBackwards();
                return;
            }

            Sequence.PlayForward();
        }

        [ContextMenu("Restart")]
        public void Restart() => Sequence.Restart();

        [ContextMenu("Complete")]
        public void Complete() => Sequence.Complete(true);

        [ContextMenu("Rewind")]
        public void Rewind() => Sequence.Rewind();

        [Serializable]
        private struct AnimationData
        {
            public DOAnimation animation;
            public bool joinPrevious;

            public void AddToSequence(Sequence sequence)
            {
                if (joinPrevious)
                {
                    sequence.Join(animation.GetAnimation());
                    return;
                }

                sequence.Append(animation.GetAnimation());
            }
        }
    }
}
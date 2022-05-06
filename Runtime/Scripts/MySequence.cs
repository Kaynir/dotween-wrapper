using DG.Tweening;
using UnityEngine;

namespace CozyDragon.Tweening
{
    public class MySequence : MonoBehaviour
    {
        [SerializeField] private bool _autoPlay = false;
        [SerializeField] private bool _timeScaleIndependant = false;
        [SerializeField] private UpdateType _updateType = UpdateType.Normal;
        [SerializeField] private TweenData[] _tweens = null;

        public Sequence Sequence { get; private set; }

        private void Awake() => Sequence = BuildSequence();

        private void OnEnable()
        {
            if (_autoPlay) Restart();
        }

        private void OnDestroy() => Sequence?.Kill();

        [ContextMenu("Restart")]
        public void Restart() => Sequence.Restart();

        [ContextMenu("Play Forward")]
        public void PlayForward() => Sequence.PlayForward();

        [ContextMenu("Play Backwards")]
        public void PlayBackwards() => Sequence.PlayBackwards();

        private Sequence BuildSequence()
        {
            Sequence sequence = DOTween.Sequence();

            sequence.Pause();
            sequence.SetAutoKill(false);
            sequence.SetUpdate(_updateType, _timeScaleIndependant);

            foreach (TweenData data in _tweens)
            {
                data.AddToSequence(sequence);
            }

            return sequence;
        }
    }
}
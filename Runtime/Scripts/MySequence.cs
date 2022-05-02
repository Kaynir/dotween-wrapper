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

        public Sequence Sequence => GetSequence();

        private Sequence _sequence;

        private void OnEnable()
        {
            if (_autoPlay) Restart();
        }

        private void OnDestroy() => _sequence?.Kill();

        [ContextMenu("Restart")]
        public void Restart() => Sequence.Restart();

        private Sequence GetSequence()
        {
            if (_sequence == null)
            {
                _sequence = DOTween.Sequence();
                _sequence.Pause();
                _sequence.SetAutoKill(false);
                _sequence.SetUpdate(_updateType, _timeScaleIndependant);

                foreach (TweenData data in _tweens)
                {
                    data.AddToSequence(_sequence);
                }
            }

            return _sequence;
        }

        [System.Serializable]
        private struct TweenData
        {
            public MyTween tween;
            public bool join;

            public void AddToSequence(Sequence sequence)
            {
                if (join)
                {
                    sequence.Join(tween.Tween);
                    return;
                }

                sequence.Append(tween.Tween);
            }
        }
    }
}
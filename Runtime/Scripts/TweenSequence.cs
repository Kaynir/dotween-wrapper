using DG.Tweening;
using System;
using UnityEngine;

namespace KaynirGames.Tweening
{
    public class TweenSequence : MonoBehaviour
    {
        [SerializeField] private TweenData[] _tweenDataArray = null;
        [SerializeField] private UpdateType _updateType = UpdateType.Normal;
        [SerializeField] private bool _isUnscaledTime = false;

        private Sequence _sequence;

        public Sequence GetSequence()
        {
            if (_sequence == null)
            {
                _sequence = CreateSequence();
            }

            return _sequence;
        }

        [ContextMenu("Restart")]
        public void Restart() => GetSequence().Restart();

        [ContextMenu("Play Forward")]
        public void PlayForward() => GetSequence().PlayForward();

        [ContextMenu("Play Backwards")]
        public void PlayBackwards() => GetSequence().PlayBackwards();

        private Sequence CreateSequence()
        {
            Sequence sequence = DOTween.Sequence();

            sequence.SetAutoKill(false);

            foreach (TweenData data in _tweenDataArray)
            {
                data.AddToSequence(sequence);
            }

            sequence.SetUpdate(_updateType, _isUnscaledTime);

            return sequence.Pause();
        }

        [Serializable]
        private struct TweenData
        {
            [SerializeField] private BaseTween _tween;
            [SerializeField] private bool _join;

            public void AddToSequence(Sequence sequence)
            {
                if (_join)
                {
                    sequence.Join(_tween.GetTween());
                    return;
                }

                sequence.Append(_tween.GetTween());
            }
        }
    }
}
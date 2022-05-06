using DG.Tweening;

namespace CozyDragon.Tweening
{
    [System.Serializable]
    public struct TweenData
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
using DG.Tweening;

namespace Kaynir.Tweening.Events
{
    public class DOCompleteEvent : DOEvent
    {
        public override void SetCallback(Tween tween)
        {
            tween.OnComplete(Callback.Invoke);
        }
    }
}
using DG.Tweening;

namespace Kaynir.Tweening.Events
{
    public class DORewindEvent : DOEvent
    {
        public override void SetCallback(Tween tween)
        {
            tween.OnRewind(Callback.Invoke);
        }
    }
}
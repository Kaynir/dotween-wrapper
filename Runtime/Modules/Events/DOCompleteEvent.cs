using DG.Tweening;

namespace Kaynir.Tweening.Modules
{
    public class DOCompleteEvent : DOUnityEvent
    {
        public override void Apply(Tween tween)
        {
            tween.OnComplete(Event.Invoke);
        }
    }
}
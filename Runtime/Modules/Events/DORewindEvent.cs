using DG.Tweening;

namespace Kaynir.Tweening.Modules
{
    public class DORewindEvent : DOUnityEvent
    {
        public override void Apply(Tween tween)
        {
            tween.OnRewind(Event.Invoke);
        }
    }
}
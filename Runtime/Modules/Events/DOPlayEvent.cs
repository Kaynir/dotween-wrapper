using DG.Tweening;

namespace Kaynir.Tweening.Modules
{
    public class DOPlayEvent : DOUnityEvent
    {
        public override void Apply(Tween tween)
        {
            tween.OnPlay(Event.Invoke);
        }
    }
}
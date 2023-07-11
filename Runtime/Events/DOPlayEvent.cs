using DG.Tweening;

namespace Kaynir.Tweening.Events
{
    public class DOPlayEvent : DOEvent
    {
        public override void SetCallback(Tween tween)
        {
            tween.OnPlay(Callback.Invoke);
        }
    }
}
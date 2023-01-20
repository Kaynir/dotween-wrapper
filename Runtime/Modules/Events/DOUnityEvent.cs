using UnityEngine;
using UnityEngine.Events;

namespace Kaynir.Tweening.Modules
{
    public abstract class DOUnityEvent : DOModule
    {
        [field: SerializeField] public UnityEvent Event { get; private set; } = new UnityEvent();
    }
}
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Kaynir.Tweening.Events
{
    public abstract class DOEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent callback = new UnityEvent();

        public UnityEvent Callback => callback;

        public abstract void SetCallback(Tween tween);
    }
}
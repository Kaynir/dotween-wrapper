using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public abstract class DOModule : MonoBehaviour
    {
        public abstract void Apply(Tween tween);
    }
}
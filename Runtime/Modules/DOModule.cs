using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public abstract class DOModule : ScriptableObject
    {
        public abstract void Apply(Tween tween);
    }
}
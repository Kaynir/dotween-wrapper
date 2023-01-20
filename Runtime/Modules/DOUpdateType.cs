using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    public class DOUpdateType : DOModule
    {
        [SerializeField] private bool _ignoreTimeScale = false;
        [SerializeField] private UpdateType _updateType = UpdateType.Normal;

        public override void Apply(Tween tween)
        {
            tween.SetUpdate(_updateType, _ignoreTimeScale);
        }
    }
}
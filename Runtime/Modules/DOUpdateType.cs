using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    [CreateAssetMenu(menuName = ASSET_MENU_NAME)]
    public class DOUpdateType : DOModule
    {
        private const string ASSET_MENU_NAME = "Scriptable Objects/Tweening/Modules/Update Type";

        [SerializeField] private bool ignoreTimeScale = false;
        [SerializeField] private UpdateType updateType = UpdateType.Normal;

        public override void Apply(Tween tween)
        {
            tween.SetUpdate(updateType, ignoreTimeScale);
        }
    }
}
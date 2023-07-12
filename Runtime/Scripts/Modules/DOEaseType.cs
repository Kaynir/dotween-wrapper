using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    [CreateAssetMenu(menuName = ASSET_MENU_NAME)]
    public class DOEaseType : DOModule
    {
        private const string ASSET_MENU_NAME = "Scriptable Objects/Tweening/Modules/Ease Type";

        [SerializeField] private Ease ease = Ease.Linear;

        public override void Apply(Tween tween)
        {
            tween.SetEase(ease);
        }
    }
}
using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    [CreateAssetMenu(menuName = ASSET_MENU_NAME)]
    public class DOEaseCurve : DOModule
    {
        private const string ASSET_MENU_NAME = "Scriptable Objects/Tweening/Modules/Ease Curve";

        [SerializeField] private AnimationCurve curve = AnimationCurve.Linear(0, 0, 1, 1);

        public override void Apply(Tween tween)
        {
            tween.SetEase(curve);
        }
    }
}
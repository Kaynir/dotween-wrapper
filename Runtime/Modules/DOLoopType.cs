using DG.Tweening;
using UnityEngine;

namespace Kaynir.Tweening.Modules
{
    [CreateAssetMenu(menuName = ASSET_MENU_NAME)]
    public class DOLoopType : DOModule
    {
        private const string ASSET_MENU_NAME = "Scriptable Objects/Tweening/Modules/Loop Type";

        [SerializeField, Min(-1)] private int loops = 0;
        [SerializeField] private LoopType loopType = LoopType.Restart;

        public override void Apply(Tween tween)
        {
            tween.SetLoops(loops, loopType);
        }
    }
}
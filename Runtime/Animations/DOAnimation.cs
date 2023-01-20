using System.Collections.Generic;
using DG.Tweening;
using Kaynir.Tweening.Modules;
using UnityEngine;

namespace Kaynir.Tweening.Animations
{
    public abstract class DOAnimation : MonoBehaviour
    {
        [SerializeField] private float _duration = .5f;
        [SerializeField] private List<DOModule> _modules = new List<DOModule>();

        public float Duration => _duration;

        public Tween GetTween()
        {
            Tween tween = CreateTween();

            _modules.ForEach(m => m.Apply(tween));

            return tween;
        }

        protected abstract Tween CreateTween();
    }
}
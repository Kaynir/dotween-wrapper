using UnityEngine;
using UnityEditor;

namespace Kaynir.Tweening.Editors
{
    [CustomEditor(typeof(DOAnimator))]
    public class DOAnimatorEditor : Editor
    {
        private DOAnimator _animator;

        private void OnEnable()
        {
            _animator = (DOAnimator)target;
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            
            DrawDefaultInspector();
            DrawButtons();
            
            serializedObject.ApplyModifiedProperties();
        }

        private void DrawButtons()
        {
            if (!Application.isPlaying) return;

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Play")) _animator.Play();
            if (GUILayout.Button("Restart")) _animator.Restart();
            if (GUILayout.Button("Complete")) _animator.Complete();
            if (GUILayout.Button("Rewind")) _animator.Rewind();

            EditorGUILayout.EndHorizontal();
        }
    }
}
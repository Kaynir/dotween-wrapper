using UnityEngine;
using UnityEditor;

namespace Kaynir.Tweening.Editors
{
    [CustomEditor(typeof(DOAnimator))]
    public class DOAnimatorEditor : Editor
    {
        private DOAnimator animator;

        private void OnEnable()
        {
            animator = (DOAnimator)target;
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

            if (GUILayout.Button("Play")) animator.Play();
            if (GUILayout.Button("Restart")) animator.Restart();
            if (GUILayout.Button("Complete")) animator.Complete();
            if (GUILayout.Button("Rewind")) animator.Rewind();

            EditorGUILayout.EndHorizontal();
        }
    }
}
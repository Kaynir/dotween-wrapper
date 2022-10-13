using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Kaynir.Tweening.Editors
{
    [CustomEditor(typeof(DOAnimator))]
    public class DOAnimatorEditor : Editor
    {
        private readonly List<string> _ignoreProperties = new List<string>() { "m_Script" };

        private readonly string[] _eventProperties = { "_onStarted", "_onCompleted", "_onRewinded" };
        private readonly string[] _eventTabs = { "Start Event", "Complete Event", "Rewind Event" };

        private DOAnimator _animator;
        private int _selectedTab;

        private SerializedProperty[] _events;

        private void OnEnable()
        {
            _animator = (DOAnimator)target;
            _ignoreProperties.AddRange(_eventProperties);
            
            _selectedTab = 0;
            _events = new SerializedProperty[_eventProperties.Length];

            for (int i = 0; i < _events.Length; i++)
            {
                _events[i] = serializedObject.FindProperty(_eventProperties[i]);
            }
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            DrawPropertiesExcluding(serializedObject, _ignoreProperties.ToArray());
            DrawEventTabs();
            serializedObject.ApplyModifiedProperties();
        }

        private void DrawEventTabs()
        {
            EditorGUILayout.BeginVertical();

            _selectedTab = GUILayout.Toolbar(_selectedTab, _eventTabs);

            EditorGUILayout.EndVertical();

            DrawProperty(_events[_selectedTab]);
            DrawButtons();
        }

        private void DrawProperty(SerializedProperty property) => EditorGUILayout.PropertyField(property);

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
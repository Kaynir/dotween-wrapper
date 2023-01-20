using UnityEngine;
using UnityEditor;

namespace Kaynir.Tweening.Editors
{
    [CustomPropertyDrawer(typeof(AnimationData))]
    public class AnimationDataDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            SerializedProperty join = property.FindPropertyRelative("_join");
            SerializedProperty animation = property.FindPropertyRelative("_animation");

            GUIContent joinTooltip = new GUIContent("Join", "Join previous animation.");
            GUIContent animationLabel = new GUIContent("Animation", "Animation to play.");

            position.height = EditorGUIUtility.singleLineHeight;
            
            EditorGUI.ObjectField(position, animation, animationLabel);

            position.y += position.height;
            
            join.boolValue = EditorGUI.PropertyField(position, join, joinTooltip);

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 2;
        }
    }
}
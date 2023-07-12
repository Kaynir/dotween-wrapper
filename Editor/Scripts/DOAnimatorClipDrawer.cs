using UnityEngine;
using UnityEditor;

namespace Kaynir.Tweening.Editors
{
    [CustomPropertyDrawer(typeof(DOAnimatorClip))]
    public class DOAnimatorClipDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            SerializedProperty join = property.FindPropertyRelative("join");
            SerializedProperty animation = property.FindPropertyRelative("animation");

            GUIContent joinTooltip = new GUIContent("Join Previous", "Join previous animation.");
            GUIContent animationLabel = new GUIContent("Animation", "Animation to play.");

            position.height = EditorGUIUtility.singleLineHeight;
            
            EditorGUI.ObjectField(position, animation, animationLabel);

            position.y += position.height;
            
            join.boolValue = EditorGUI.Toggle(position, joinTooltip, join.boolValue);

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 2;
        }
    }
}
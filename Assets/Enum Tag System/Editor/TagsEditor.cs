using UnityEngine;
using UnityEditor;

namespace EnumTagSystem
{
    [CustomEditor(typeof(Tags))]
    public class TagsEditor : Editor
    {
        private void OnEnable()
        {
            var castedTarget = target as Tags;
            castedTarget.hideFlags = HideFlags.HideInInspector;
        }
    }
}

using UnityEditor;
using UnityEngine;

namespace EnumTagSystem
{
    [InitializeOnLoad]
    static class EditorHeaderTags
    {
        static EditorHeaderTags()
        {
            Editor.finishedDefaultHeaderGUI += DisplayTagsHeader;
        }

        static void DisplayTagsHeader(Editor editor)
        {
            if (Selection.gameObjects.Length == 0)
                return;

            var controlRect = EditorGUI.PrefixLabel(EditorGUILayout.GetControlRect(), EditorGUIUtility.TrTextContent("Enum Tags"));

            if(Selection.count > 1)
            {
                //todo multiple object editing
                EditorGUI.LabelField(controlRect, EditorGUIUtility.TrTempContent("Multiple object editing not supported"));
            }
            else
            {
                var tag = Selection.gameObjects[0].GetComponent<Tags>();
                if (tag == null)
                    tag = Selection.gameObjects[0].AddComponent<Tags>();
                var oldTag = tag.tags;
                tag.tags = (TagEnums)EditorGUI.EnumFlagsField(controlRect, tag.tags);
                if(tag.tags != oldTag)
                {
                    EditorUtility.SetDirty(tag);
                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTagSystem
{
    public static class GameObjectExtensions
    {
        public static bool HasTags(this GameObject go, TagEnums tags)
        {
            return go.GetComponent<Tags>().HasTags(tags);
        }
    }
}

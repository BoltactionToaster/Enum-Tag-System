using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTagSystem
{
    public class Tags : MonoBehaviour
    {
        public TagEnums tags;

        public bool HasTags(TagEnums tags)
        {
            return this.tags.HasFlag(tags);
        }
    }

}

#if UNITY_EDITOR
using UnityEngine;

namespace NaughtyAttributes
{
    /// <summary>
    /// Base class for all drawer attributes
    /// </summary>
    public class DrawerAttribute : PropertyAttribute, INaughtyAttribute
    {
    }
}
#endif

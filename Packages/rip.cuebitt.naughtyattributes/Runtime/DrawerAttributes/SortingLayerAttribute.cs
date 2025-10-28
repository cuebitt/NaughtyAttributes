#if UNITY_EDITOR
using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SortingLayerAttribute : DrawerAttribute
    {
    }
}
#endif

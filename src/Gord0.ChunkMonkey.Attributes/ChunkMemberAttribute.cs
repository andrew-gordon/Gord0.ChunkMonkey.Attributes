using System;

namespace Gord0.ChunkMonkey.Attributes
{
    /// <summary>
    /// Specifies that a field or property is a member of a chunk.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ChunkMemberAttribute : Attribute
    {
    }
}

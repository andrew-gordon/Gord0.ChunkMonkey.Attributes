using System;

namespace Gord0.ChunkMonkey.Attributes
{
    /// <summary>
    /// Specifies that the class can be chunked. Optionally, the accessibility of the members to be chunked can be specified.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ChunkAttribute(Accessibility accessibility = Accessibility.Public) : Attribute
    {
        /// <summary>
        /// Gets the class member's accessibility.
        /// </summary>
        public Accessibility Accessibility { get; } = accessibility;
    }
}

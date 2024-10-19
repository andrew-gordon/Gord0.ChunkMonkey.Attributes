using System;

namespace Gordo.ChunkyMonkey.Attributes
{
    /// <summary>
    /// Specifies that the class can be chunked. Optionally, the visibility of the members to be chunked can be specified.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ChunkAttribute(MemberAccessor memberAccessor = MemberAccessor.Public) : Attribute
    {
        /// <summary>
        /// Gets the member accessor for the chunked class.
        /// </summary>
        public MemberAccessor MemberAccessor { get; } = memberAccessor;
    }
}

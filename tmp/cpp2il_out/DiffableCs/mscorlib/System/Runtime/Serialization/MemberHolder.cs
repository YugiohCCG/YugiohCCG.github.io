namespace System.Runtime.Serialization;

internal sealed class MemberHolder
{
	internal readonly Type _memberType; //Field offset: 0x10
	internal readonly StreamingContext _context; //Field offset: 0x18

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal MemberHolder(Type type, StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}


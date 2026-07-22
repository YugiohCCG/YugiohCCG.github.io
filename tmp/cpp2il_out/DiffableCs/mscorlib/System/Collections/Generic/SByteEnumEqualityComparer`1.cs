namespace System.Collections.Generic;

internal sealed class SByteEnumEqualityComparer : EnumEqualityComparer<T>, ISerializable
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SByteEnumEqualityComparer`1() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SByteEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(sbyte), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode(T obj) { }

}


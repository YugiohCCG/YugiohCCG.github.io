namespace Newtonsoft.Json.Utilities;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct StructMultiKey : IEquatable<StructMultiKey`2<T1, T2>>
{
	public readonly T1 Value1; //Field offset: 0x0
	public readonly T2 Value2; //Field offset: 0x0

	[CallerCount(Count = 68)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public StructMultiKey`2(T1 v1, T2 v2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool Equals(StructMultiKey<T1, T2> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}


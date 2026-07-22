namespace Unity.Collections;

internal struct ListPair
{
	public Key key; //Field offset: 0x0
	public Value value; //Field offset: 0x0

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public ListPair`2(Key k, Value v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 33)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}


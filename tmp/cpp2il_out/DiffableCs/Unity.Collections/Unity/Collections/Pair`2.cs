namespace Unity.Collections;

internal struct Pair
{
	public Key key; //Field offset: 0x0
	public Value value; //Field offset: 0x0

	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public Pair`2(Key k, Value v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}


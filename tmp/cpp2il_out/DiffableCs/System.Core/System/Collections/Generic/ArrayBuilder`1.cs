namespace System.Collections.Generic;

[DefaultMember("Item")]
internal struct ArrayBuilder
{
	private T[] _array; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ArrayBuilder`1(int capacity) { }

	[CalledBy(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void UncheckedAdd(T item) { }

}


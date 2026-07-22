namespace System.Collections.Generic;

internal class GenericComparer : Comparer<T>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public GenericComparer`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`1), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`1<T1>"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int Compare(T x, T y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}


namespace System.Collections.Generic;

internal sealed class TreeSet : SortedSet<T>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TreeSet`1() { }

	[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TreeSet`1(IComparer<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TreeSet`1(SerializationInfo siInfo, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal virtual bool AddIfNotPresent(T item) { }

}


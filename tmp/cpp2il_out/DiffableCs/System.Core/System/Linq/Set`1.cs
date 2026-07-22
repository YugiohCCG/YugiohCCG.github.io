namespace System.Linq;

internal class Set
{
	public struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal TElement value; //Field offset: 0x0
		internal int next; //Field offset: 0x0

	}

	private Int32[] buckets; //Field offset: 0x0
	private Slot<TElement>[] slots; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int freeList; //Field offset: 0x0
	private IEqualityComparer<TElement> comparer; //Field offset: 0x0

	[CalledBy(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Char>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Char>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public Set`1(IEqualityComparer<TElement> comparer) { }

	[CalledBy(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Set`1), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement", typeof(bool)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool Add(TElement value) { }

	[CalledBy(Type = typeof(Set`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool Find(TElement value, bool add) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal int InternalGetHashCode(TElement value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(TElement value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void Resize() { }

}


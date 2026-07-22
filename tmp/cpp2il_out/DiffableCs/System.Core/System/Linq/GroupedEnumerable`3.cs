namespace System.Linq;

internal class GroupedEnumerable : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
{
	private IEnumerable<TSource> source; //Field offset: 0x0
	private Func<TSource, TKey> keySelector; //Field offset: 0x0
	private Func<TSource, TElement> elementSelector; //Field offset: 0x0
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[CalledBy(Type = typeof(Enumerable), Member = "GroupBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public GroupedEnumerable`3(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lookup`2), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>")]
	[Calls(Type = typeof(Lookup`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IGrouping`2<TKey, TElement>>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lookup`2), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>")]
	[Calls(Type = typeof(Lookup`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IGrouping`2<TKey, TElement>>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


namespace System.Linq;

internal class OrderedEnumerable : OrderedEnumerable<TElement>
{
	internal OrderedEnumerable<TElement> parent; //Field offset: 0x0
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	internal IComparer<TKey> comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0

	[CalledBy(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(OrderedEnumerable`1), Member = "System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = "System.Linq.IOrderedEnumerable`1<TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Single>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Single>))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal OrderedEnumerable`2(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumerableSorter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool), "System.Linq.EnumerableSorter`1<TElement>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

}


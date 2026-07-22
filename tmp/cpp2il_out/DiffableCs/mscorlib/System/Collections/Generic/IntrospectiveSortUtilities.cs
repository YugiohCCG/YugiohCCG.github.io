namespace System.Collections.Generic;

internal static class IntrospectiveSortUtilities
{

	[CalledBy(Type = "System.Array+SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal static int FloorLog2PlusOne(int n) { }

	[CalledBy(Type = "System.Array+SorterObjectArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Array+SorterGenericArray", Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void ThrowOrIgnoreBadComparer(object comparer) { }

}


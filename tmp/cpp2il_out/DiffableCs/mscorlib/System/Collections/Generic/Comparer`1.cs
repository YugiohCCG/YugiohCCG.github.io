namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer : IComparer, IComparer<T>
{
	private static Comparer<T> defaultComparer; //Field offset: 0x0

	public static Comparer<T> Default
	{
		[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 268
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Comparer`1() { }

	public abstract int Compare(T x, T y) { }

	[CalledBy(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	private static Comparer<T> CreateComparer() { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static Comparer<T> get_Default() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override int System.Collections.IComparer.Compare(object x, object y) { }

}


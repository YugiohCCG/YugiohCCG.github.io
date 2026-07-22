namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer : IEqualityComparer, IEqualityComparer<T>
{
	private static EqualityComparer<T> defaultComparer; //Field offset: 0x0

	public static EqualityComparer<T> Default
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 268
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EqualityComparer`1() { }

	[CalledBy(Type = typeof(Array), Member = "IndexOfImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ObjectEqualityComparer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InternalStringComparer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ByteEqualityComparer), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 38)]
	[DeduplicatedMethod]
	private static EqualityComparer<T> CreateComparer() { }

	public abstract bool Equals(T x, T y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static EqualityComparer<T> get_Default() { }

	public abstract int GetHashCode(T obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}


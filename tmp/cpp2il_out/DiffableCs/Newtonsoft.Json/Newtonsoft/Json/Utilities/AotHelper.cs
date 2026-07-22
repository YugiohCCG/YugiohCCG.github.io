namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
public static class AotHelper
{
	[CompilerGenerated]
	private sealed class <>c__1
	{
		[Nullable(0)]
		public static readonly <>c__1<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Action <>9__1_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__1`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__1`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <EnsureType>b__1_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__2
	{
		[Nullable(0)]
		public static readonly <>c__2<T> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Action <>9__2_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__2`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__2`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal void <EnsureList>b__2_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__3
	{
		[Nullable(0)]
		public static readonly <>c__3<TKey, TValue> <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Action <>9__3_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private static <>c__3`2() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__3`2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal void <EnsureDictionary>b__3_0() { }

	}

	private static bool s_alwaysFalse; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	private static AotHelper() { }

	[CalledBy(Type = typeof(AotHelper), Member = "EnsureType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AotHelper), Member = "EnsureList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AotHelper), Member = "EnsureDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[NullableContext(1)]
	public static void Ensure(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AotHelper), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void EnsureDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AotHelper), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void EnsureList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AotHelper), Member = "Ensure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void EnsureType() { }

	[CallerCount(Count = 0)]
	public static bool IsFalse() { }

}


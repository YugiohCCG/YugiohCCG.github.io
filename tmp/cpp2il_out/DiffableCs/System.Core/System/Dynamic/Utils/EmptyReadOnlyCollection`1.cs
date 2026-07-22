namespace System.Dynamic.Utils;

internal static class EmptyReadOnlyCollection
{
	public static readonly ReadOnlyCollection<T> Instance; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private static EmptyReadOnlyCollection`1() { }

}


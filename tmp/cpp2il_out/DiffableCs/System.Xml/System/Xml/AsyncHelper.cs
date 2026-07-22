namespace System.Xml;

[Extension]
internal static class AsyncHelper
{
	public static readonly Task DoneTask; //Field offset: 0x0
	public static readonly Task<Boolean> DoneTaskTrue; //Field offset: 0x8
	public static readonly Task<Boolean> DoneTaskFalse; //Field offset: 0x10
	public static readonly Task<Int32> DoneTaskZero; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsUnknownMethods(Count = 4)]
	private static AsyncHelper() { }

}


namespace Discord;

public class ResultException : Exception
{
	public readonly Result Result; //Field offset: 0x90

	[CallerCount(Count = 115)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ResultException(Result result) { }

}


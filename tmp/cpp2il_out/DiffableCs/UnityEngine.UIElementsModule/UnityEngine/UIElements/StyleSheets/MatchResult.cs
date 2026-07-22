namespace UnityEngine.UIElements.StyleSheets;

internal struct MatchResult
{
	public MatchResultErrorCode errorCode; //Field offset: 0x0
	public string errorValue; //Field offset: 0x8

	public bool success
	{
		[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 9
	}

	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_success() { }

}


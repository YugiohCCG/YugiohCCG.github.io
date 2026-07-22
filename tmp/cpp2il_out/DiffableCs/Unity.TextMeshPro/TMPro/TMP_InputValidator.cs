namespace TMPro;

public abstract class TMP_InputValidator : ScriptableObject
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected TMP_InputValidator() { }

	public abstract char Validate(ref string text, ref int pos, char ch) { }

}


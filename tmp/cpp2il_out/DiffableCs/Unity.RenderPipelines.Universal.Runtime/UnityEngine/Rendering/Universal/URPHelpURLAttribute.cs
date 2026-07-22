namespace UnityEngine.Rendering.Universal;

[Conditional("UNITY_EDITOR")]
internal class URPHelpURLAttribute : CoreRPHelpURLAttribute
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreRPHelpURLAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public URPHelpURLAttribute(string pageName, string pageHash = "") { }

}


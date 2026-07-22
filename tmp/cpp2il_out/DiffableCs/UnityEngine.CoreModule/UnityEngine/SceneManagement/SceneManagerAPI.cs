namespace UnityEngine.SceneManagement;

public class SceneManagerAPI
{
	private static SceneManagerAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SceneManagerAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	internal static SceneManagerAPI ActiveAPI
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 184
	}

	public static SceneManagerAPI overrideAPI
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static SceneManagerAPI() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private SceneManagerAPI() { }

	[CallerCount(Count = 0)]
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static SceneManagerAPI get_overrideAPI() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected private override AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

}


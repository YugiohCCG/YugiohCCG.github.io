namespace UnityEngine.Rendering;

public abstract class RenderPipelineResources : ScriptableObject
{

	protected override string packagePath
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal string packagePath_Internal
	{
		[CallerCount(Count = 51)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 17
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected RenderPipelineResources() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	protected override string get_packagePath() { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal string get_packagePath_Internal() { }

}


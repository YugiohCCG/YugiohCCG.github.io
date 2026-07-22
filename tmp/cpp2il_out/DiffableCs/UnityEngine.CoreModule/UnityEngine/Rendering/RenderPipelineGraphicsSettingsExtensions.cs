namespace UnityEngine.Rendering;

[Extension]
public static class RenderPipelineGraphicsSettingsExtensions
{

	[CallerCount(Count = 58)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void SetValueAndNotify(IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName = null) { }

}


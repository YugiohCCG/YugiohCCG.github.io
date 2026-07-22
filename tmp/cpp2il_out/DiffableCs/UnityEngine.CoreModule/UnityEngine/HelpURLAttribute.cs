namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[UsedByNativeCode]
public class HelpURLAttribute : Attribute
{
	internal readonly string m_Url; //Field offset: 0x10
	internal readonly bool m_Dispatcher; //Field offset: 0x18
	internal readonly string m_DispatchingFieldName; //Field offset: 0x20

	public override string URL
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.Rendering.CoreRPHelpURLAttribute", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreRPHelpURLAttribute", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CurrentPipelineHelpURLAttribute", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RayTracingShaderHelpURLAttribute), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public HelpURLAttribute(string url) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override string get_URL() { }

}


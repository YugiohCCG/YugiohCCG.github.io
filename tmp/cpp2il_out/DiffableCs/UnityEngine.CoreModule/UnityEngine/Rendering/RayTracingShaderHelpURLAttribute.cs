namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Experimental.Rendering")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingAccelerationStructure.h")]
internal class RayTracingShaderHelpURLAttribute : HelpURLAttribute
{

	public virtual string URL
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_unityVersionVer", ReturnType = typeof(int))]
		[Calls(Type = typeof(Application), Member = "get_unityVersionMaj", ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HelpURLAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public RayTracingShaderHelpURLAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_unityVersionVer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Application), Member = "get_unityVersionMaj", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string get_URL() { }

}


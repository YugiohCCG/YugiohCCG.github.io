namespace UnityEngine.Rendering;

public interface IGPUResidentRenderPipeline
{

	public GPUResidentDrawerMode gpuResidentDrawerMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public GPUResidentDrawerSettings gpuResidentDrawerSettings
	{
		 get { } //Length: 0
	}

	public GPUResidentDrawerMode get_gpuResidentDrawerMode() { }

	public GPUResidentDrawerSettings get_gpuResidentDrawerSettings() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsGPUResidentDrawerEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsProjectSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public static bool IsGPUResidentDrawerSupportedByProjectConfiguration(bool logReason = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGPUResidentDrawerSupportedBySRP(bool logReason = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "GetGlobalSettingsFromRPAsset", ReturnType = typeof(GPUResidentDrawerSettings))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = "IsGPUResidentDrawerSupportedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void ReinitializeGPUResidentDrawer() { }

	public void set_gpuResidentDrawerMode(GPUResidentDrawerMode value) { }

}


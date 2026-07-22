namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
{
	[CompilerGenerated]
	private DebugDisplaySettingsCommon <commonSettings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DebugDisplaySettingsMaterial <materialSettings>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DebugDisplaySettingsRendering <renderingSettings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DebugDisplaySettingsLighting <lightingSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private DebugDisplaySettingsVolume <volumeSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private DebugDisplaySettingsStats<URPProfileId> <displayStats>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private DebugDisplayGPUResidentDrawer <gpuResidentDrawerSettings>k__BackingField; //Field offset: 0x48

	private DebugDisplaySettingsCommon commonSettings
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal DebugDisplaySettingsStats<URPProfileId> displayStats
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal DebugDisplayGPUResidentDrawer gpuResidentDrawerSettings
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public virtual bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 655
	}

	public private DebugDisplaySettingsLighting lightingSettings
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private DebugDisplaySettingsMaterial materialSettings
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private DebugDisplaySettingsRendering renderingSettings
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private DebugDisplaySettingsVolume volumeSettings
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugDisplaySettings`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public UniversalRenderPipelineDebugDisplaySettings() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private DebugDisplaySettingsCommon get_commonSettings() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DebugDisplaySettingsStats<URPProfileId> get_displayStats() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DebugDisplayGPUResidentDrawer get_gpuResidentDrawerSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public virtual bool get_IsPostProcessingAllowed() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugDisplaySettingsLighting get_lightingSettings() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugDisplaySettingsMaterial get_materialSettings() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugDisplaySettingsRendering get_renderingSettings() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugDisplaySettingsVolume get_volumeSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugDisplaySettings`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugFrameTiming), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplayStats`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplaySettings`1), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TData"}, ReturnType = "TData")]
	[Calls(Type = typeof(DebugDisplaySettingsMaterial), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplaySettingsVolume), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IVolumeDebugSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplayGPUResidentDrawer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_streamingTextureDiscardUnusedMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public virtual void Reset() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_commonSettings(DebugDisplaySettingsCommon value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_displayStats(DebugDisplaySettingsStats<URPProfileId> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_gpuResidentDrawerSettings(DebugDisplayGPUResidentDrawer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lightingSettings(DebugDisplaySettingsLighting value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_materialSettings(DebugDisplaySettingsMaterial value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_renderingSettings(DebugDisplaySettingsRendering value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_volumeSettings(DebugDisplaySettingsVolume value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateDisplayStats() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = "SetStreamingTextureMaterialDebugProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateMaterials() { }

}


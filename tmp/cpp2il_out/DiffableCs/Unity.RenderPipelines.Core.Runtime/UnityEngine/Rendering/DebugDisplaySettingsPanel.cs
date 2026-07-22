namespace UnityEngine.Rendering;

public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
{
	private readonly List<Widget> m_Widgets; //Field offset: 0x10
	private readonly DisplayInfoAttribute m_DisplayInfo; //Field offset: 0x18

	public override Flags Flags
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int Order
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	public override string PanelName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 39
	}

	public override Widget[] Widgets
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	[CalledBy(Type = typeof(DebugDisplaySettingsPanel`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsStats`1+StatsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsStats`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsRenderGraph+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected DebugDisplaySettingsPanel() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsStats`1+StatsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsStats`1<TProfileId>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsRenderGraph+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddInstanceCullingStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddOcclusionContextStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	protected void AddWidget(Widget widget) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void Clear() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Flags get_Flags() { }

	[CallerCount(Count = 0)]
	public override int get_Order() { }

	[CallerCount(Count = 0)]
	public override string get_PanelName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 1)]
	public override Widget[] get_Widgets() { }

}


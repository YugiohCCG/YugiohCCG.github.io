namespace UnityEngine.Rendering.RenderGraphModule;

internal class RenderGraphDebugParams : IDebugDisplaySettingsQuery
{
	private static class Strings
	{
		public static readonly NameAndTooltip ClearRenderTargetsAtCreation; //Field offset: 0x0
		public static readonly NameAndTooltip ClearRenderTargetsAtFree; //Field offset: 0x10
		public static readonly NameAndTooltip DisablePassCulling; //Field offset: 0x20
		public static readonly NameAndTooltip ImmediateMode; //Field offset: 0x30
		public static readonly NameAndTooltip EnableLogging; //Field offset: 0x40
		public static readonly NameAndTooltip LogFrameInformation; //Field offset: 0x50
		public static readonly NameAndTooltip LogResources; //Field offset: 0x60
		public static readonly NameAndTooltip EnableNativeCompiler; //Field offset: 0x70

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 24)]
		private static Strings() { }

	}

	private Widget[] m_DebugItems; //Field offset: 0x10
	private Panel m_DebugPanel; //Field offset: 0x18
	public bool clearRenderTargetsAtCreation; //Field offset: 0x20
	public bool clearRenderTargetsAtRelease; //Field offset: 0x21
	public bool disablePassCulling; //Field offset: 0x22
	public bool immediateMode; //Field offset: 0x23
	public bool enableLogging; //Field offset: 0x24
	public bool logFrameInformation; //Field offset: 0x25
	public bool logResources; //Field offset: 0x26

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 32
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphDebugParams() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <GetWidgetList>b__11_0() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <GetWidgetList>b__11_1(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <GetWidgetList>b__11_10(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <GetWidgetList>b__11_11() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private void <GetWidgetList>b__11_12() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <GetWidgetList>b__11_2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <GetWidgetList>b__11_3(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <GetWidgetList>b__11_4() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <GetWidgetList>b__11_5(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <GetWidgetList>b__11_6() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void <GetWidgetList>b__11_7(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private bool <GetWidgetList>b__11_8() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <GetWidgetList>b__11_9() { }

	[CallerCount(Count = 0)]
	public override bool get_AreAnySettingsActive() { }

	[CalledBy(Type = typeof(RenderGraphDebugParams), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Panel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "GetWidgetList", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[CalledBy(Type = typeof(RenderGraph), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 17)]
	internal List<Widget> GetWidgetList(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[CallsUnknownMethods(Count = 2)]
	private bool IsImmediateModeSupported() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphDebugParams), Member = "GetWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterDebug(string name, Panel debugPanel = null) { }

	[CalledBy(Type = typeof(DebugDisplaySettingsRenderGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObservableList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void UnRegisterDebug(string name) { }

}


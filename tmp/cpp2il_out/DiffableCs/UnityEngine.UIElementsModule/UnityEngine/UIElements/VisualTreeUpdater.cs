namespace UnityEngine.UIElements;

internal sealed class VisualTreeUpdater : IDisposable
{
	[DefaultMember("Item")]
	private class UpdaterArray
	{
		private IVisualTreeUpdater[] m_VisualTreeUpdaters; //Field offset: 0x10

		public IVisualTreeUpdater Item
		{
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 43
			[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 6)]
			 set { } //Length: 123
		}

		public IVisualTreeUpdater Item
		{
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 43
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public UpdaterArray() { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public IVisualTreeUpdater get_Item(int index) { }

		[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	}

	private BaseVisualElementPanel m_Panel; //Field offset: 0x10
	private UpdaterArray m_UpdaterArray; //Field offset: 0x18

	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public VisualTreeUpdater(BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Panel), Member = "GetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(IVisualTreeUpdater))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[CalledBy(Type = typeof(Panel), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	private void SetDefaultUpdaters() { }

	[CalledBy(Type = typeof(Panel), Member = "SetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IVisualTreeUpdater), typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[CalledBy(Type = typeof(VisualTreeUpdater), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeUpdater), Member = "SetDefaultUpdaters", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UpdaterArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase), typeof(IVisualTreeUpdater)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	[CalledBy(Type = typeof(Panel), Member = "ValidateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "ApplyStyles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "UpdateForRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Repaint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

}


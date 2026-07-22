namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass524_0
	{
		public VisualElement <>4__this; //Field offset: 0x10
		public StyleValues to; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass524_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "ReadCurrentValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleValues)}, ReturnType = typeof(StyleValues))]
		[CallsUnknownMethods(Count = 1)]
		internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

	}

	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private VisualElement <element>k__BackingField; //Field offset: 0x38
		public IScheduler scheduler; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <isActive>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <isDetaching>k__BackingField; //Field offset: 0x49
		private readonly EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; //Field offset: 0x50
		private readonly EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; //Field offset: 0x58

		public private override VisualElement element
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

		public private override bool isActive
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public private bool isDetaching
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public bool isScheduled
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 9
		}

		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScheduledItem), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		protected BaseVisualElementScheduledItem(VisualElement handler) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool CanBeActivated() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public override IVisualElementScheduledItem Every(long intervalMs) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendActivation", ReturnType = typeof(void))]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void ExecuteLater(long delayMs) { }

		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override VisualElement get_element() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override bool get_isActive() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_isDetaching() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isScheduled() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "OnPanelDeactivate", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendActivation", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void OnElementAttachToPanelCallback(AttachToPanelEvent evt) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendDeactivation", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private void OnElementDetachFromPanelCallback(DetachFromPanelEvent evt) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal virtual void OnItemUnscheduled() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public void OnPanelActivate() { }

		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnElementAttachToPanelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void OnPanelDeactivate() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendDeactivation", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public override void Pause() { }

		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		public override void Resume() { }

		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnElementAttachToPanelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "ExecuteLater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private void SendActivation() { }

		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnElementDetachFromPanelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DetachFromPanelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "Pause", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void SendDeactivation() { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_element(VisualElement value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_isActive(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_isDetaching(bool value) { }

		[CalledBy(Type = typeof(BaseVisualElementScheduledItem), Member = "OnItemUnscheduled", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendDeactivation", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "SendActivation", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private void SetActive(bool action) { }

		[CallerCount(Count = 0)]
		public override IVisualElementScheduledItem StartingIn(long delayMs) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IVisualElementScheduledItem Until(Func<Boolean> stopCondition) { }

	}

	public class CustomStyleAccess : ICustomStyle
	{
		private Dictionary<String, StylePropertyValue> m_CustomProperties; //Field offset: 0x10
		private float m_DpiScaling; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CustomStyleAccess() { }

		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Single>), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color>), typeof(Color&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

		[CalledBy(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void SetContext(Dictionary<String, StylePropertyValue> customProperties, float dpiScaling) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Single&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheet), Member = "TryReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(StyleSheetColor), Member = "TryGetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		public override bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CustomStyleAccess), Member = "LogCustomPropertyWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StyleValueType), typeof(StylePropertyValue)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	}

	[DefaultMember("Item")]
	internal struct Hierarchy
	{
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; //Field offset: 0x0
		private readonly VisualElement m_Owner; //Field offset: 0x0

		public int childCount
		{
			[CallerCount(Count = 29)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 71
		}

		internal List<VisualElement> children
		{
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 29
		}

		public VisualElement Item
		{
			[CallerCount(Count = 31)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 92
		}

		public VisualElement parent
		{
			[CallerCount(Count = 148)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 29
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Hierarchy(VisualElement element) { }

		[CallerCount(Count = 40)]
		[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public void Add(VisualElement child) { }

		[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "set_makeFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void BringToFront(VisualElement child) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public IEnumerable<VisualElement> Children() { }

		[CalledBy(Type = typeof(TextInputBase), Member = "SetSingleLine", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "DirtyNextParentWithEventInterests", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_requireMeasureFunction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(Hierarchy), Member = "ReleaseChildList", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementListPool), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		public void Clear() { }

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public VisualElement ElementAt(int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool Equals(Hierarchy other) { }

		[CallerCount(Count = 29)]
		[CallsUnknownMethods(Count = 1)]
		public int get_childCount() { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal List<VisualElement> get_children() { }

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public VisualElement get_Item(int key) { }

		[CallerCount(Count = 148)]
		[CallsUnknownMethods(Count = 1)]
		public VisualElement get_parent() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual int GetHashCode() { }

		[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "FindElementInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public int IndexOf(VisualElement element) { }

		[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LayoutNode), Member = "get_IsMeasureDefined", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		[ContainsUnimplementedInstructions]
		public void Insert(int index, VisualElement child) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "PutChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool op_Equality(Hierarchy x, Hierarchy y) { }

		[CalledBy(Type = typeof(VisualElement), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void PlaceBehind(VisualElement child, VisualElement over) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(LayoutNode), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(LayoutNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutNode), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		private void PutChildAtIndex(VisualElement child, int index) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private void ReleaseChildList() { }

		[CalledBy(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public void Remove(VisualElement child) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_requireMeasureFunction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "RemoveChildAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "ChangeIMGUIContainerCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "ReleaseChildList", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "AssignMeasureFunction", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		public void RemoveAt(int index) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
		[Calls(Type = typeof(LayoutNode), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private void RemoveChildAtIndex(int index) { }

		[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void SendToBack(VisualElement child) { }

		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "DirtyNextParentWithEventInterests", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private void SetParent(VisualElement value) { }

	}

	internal enum MeasureMode
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2,
	}

	public enum RenderTargetMode
	{
		None = 0,
		NoColorConversion = 1,
		LinearToGamma = 2,
		GammaToLinear = 3,
	}

	private class SimpleScheduledItem : VisualElementScheduledItem<Action>
	{

		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		public SimpleScheduledItem(VisualElement handler, Action updateEvent) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	private class TimerStateScheduledItem : VisualElementScheduledItem<Action`1<TimerState>>
	{

		[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.IVisualElementScheduler.Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(IVisualElementScheduledItem))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+VisualElementScheduledItem`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "ActionType"}, ReturnType = typeof(void))]
		public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	public class TypeData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Type <type>k__BackingField; //Field offset: 0x10
		private string m_FullTypeName; //Field offset: 0x18
		private string m_TypeName; //Field offset: 0x20

		public string fullTypeName
		{
			[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 80
		}

		public Type type
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string typeName
		{
			[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 192
		}

		[CalledBy(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public TypeData(Type type) { }

		[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public string get_fullTypeName() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Type get_type() { }

		[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public string get_typeName() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
		private UxmlBoolAttributeDescription m_EnabledSelf; //Field offset: 0x20
		private UxmlStringAttributeDescription m_ViewDataKey; //Field offset: 0x28
		protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; //Field offset: 0x30
		private UxmlStringAttributeDescription m_Tooltip; //Field offset: 0x38
		private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private UxmlIntAttributeDescription <focusIndex>k__BackingField; //Field offset: 0x48
		private UxmlIntAttributeDescription m_TabIndex; //Field offset: 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private UxmlBoolAttributeDescription <focusable>k__BackingField; //Field offset: 0x58
		private UxmlStringAttributeDescription m_Class; //Field offset: 0x60
		private UxmlStringAttributeDescription m_ContentContainer; //Field offset: 0x68
		private UxmlStringAttributeDescription m_Style; //Field offset: 0x70
		private UxmlAssetAttributeDescription<Object> m_DataSource; //Field offset: 0x78
		private UxmlStringAttributeDescription m_DataSourcePath; //Field offset: 0x80

		protected UxmlBoolAttributeDescription focusable
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		protected UxmlIntAttributeDescription focusIndex
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 254
		}

		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAssetAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 34)]
		public UxmlTraits() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected UxmlBoolAttributeDescription get_focusable() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected UxmlIntAttributeDescription get_focusIndex() { }

		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_dataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private abstract class VisualElementScheduledItem : BaseVisualElementScheduledItem
	{
		public ActionType updateEvent; //Field offset: 0x0

		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+TimerStateScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement+SimpleScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public VisualElementScheduledItem`1(VisualElement handler, ActionType upEvent) { }

	}

	private static uint s_NextId; //Field offset: 0x0
	internal const string k_RootVisualContainerName = "rootVisualContainer"; //Field offset: 0x0
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3; //Field offset: 0x0
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25; //Field offset: 0x0
	private static List<String> s_EmptyClassList; //Field offset: 0x8
	internal static readonly PropertyName userDataPropertyKey; //Field offset: 0x10
	public static readonly string disabledUssClassName; //Field offset: 0x18
	internal static readonly Rect s_InfiniteRect; //Field offset: 0x20
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; //Field offset: 0x30
	private static Material s_runtimeMaterial; //Field offset: 0x38
	internal static readonly BindingId childCountProperty; //Field offset: 0x40
	internal static readonly BindingId contentRectProperty; //Field offset: 0xD8
	internal static readonly BindingId dataSourcePathProperty; //Field offset: 0x170
	internal static readonly BindingId dataSourceProperty; //Field offset: 0x208
	internal static readonly BindingId disablePlayModeTintProperty; //Field offset: 0x2A0
	internal static readonly BindingId enabledInHierarchyProperty; //Field offset: 0x338
	internal static readonly BindingId enabledSelfProperty; //Field offset: 0x3D0
	internal static readonly BindingId layoutProperty; //Field offset: 0x468
	internal static readonly BindingId languageDirectionProperty; //Field offset: 0x500
	internal static readonly BindingId localBoundProperty; //Field offset: 0x598
	internal static readonly BindingId nameProperty; //Field offset: 0x630
	internal static readonly BindingId panelProperty; //Field offset: 0x6C8
	internal static readonly BindingId pickingModeProperty; //Field offset: 0x760
	internal static readonly BindingId styleSheetsProperty; //Field offset: 0x7F8
	internal static readonly BindingId tooltipProperty; //Field offset: 0x890
	internal static readonly BindingId usageHintsProperty; //Field offset: 0x928
	internal static readonly BindingId userDataProperty; //Field offset: 0x9C0
	internal static readonly BindingId viewDataKeyProperty; //Field offset: 0xA58
	internal static readonly BindingId visibleProperty; //Field offset: 0xAF0
	internal static readonly BindingId visualTreeAssetSourceProperty; //Field offset: 0xB88
	internal static readonly BindingId worldBoundProperty; //Field offset: 0xC20
	internal static readonly BindingId worldTransformProperty; //Field offset: 0xCB8
	private static uint s_NextParentVersion; //Field offset: 0xD50
	private static readonly List<VisualElement> s_EmptyList; //Field offset: 0xD58
	internal static CustomStyleAccess s_CustomStyleAccess; //Field offset: 0xD60
	private static readonly Regex s_InternalStyleSheetPath; //Field offset: 0xD68
	internal static readonly PropertyName tooltipPropertyKey; //Field offset: 0xD70
	private static readonly Dictionary<Type, TypeData> s_TypeData; //Field offset: 0xD78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; //Field offset: 0x34
	private string m_Name; //Field offset: 0x38
	private List<String> m_ClassList; //Field offset: 0x40
	private Dictionary<PropertyName, Object> m_PropertyBag; //Field offset: 0x48
	internal VisualElementFlags m_Flags; //Field offset: 0x50
	private string m_ViewDataKey; //Field offset: 0x58
	private RenderHints m_RenderHints; //Field offset: 0x60
	internal Rect lastLayout; //Field offset: 0x64
	internal Rect lastPseudoPadding; //Field offset: 0x74
	internal RenderChainVEData renderChainData; //Field offset: 0x88
	internal bool shouldCutRenderChain; //Field offset: 0x1B8
	internal UIRenderer uiRenderer; //Field offset: 0x1C0
	private Rect m_Layout; //Field offset: 0x1C8
	private Rect m_BoundingBox; //Field offset: 0x1D8
	private Rect m_WorldBoundingBox; //Field offset: 0x1E8
	private Matrix4x4 m_WorldTransformCache; //Field offset: 0x1F8
	private Matrix4x4 m_WorldTransformInverseCache; //Field offset: 0x238
	private Rect m_WorldClip; //Field offset: 0x278
	private Rect m_WorldClipMinusGroup; //Field offset: 0x288
	private bool m_WorldClipIsInfinite; //Field offset: 0x298
	internal PseudoStates triggerPseudoMask; //Field offset: 0x29C
	internal PseudoStates dependencyPseudoMask; //Field offset: 0x2A0
	private PseudoStates m_PseudoStates; //Field offset: 0x2A4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <containedPointerIds>k__BackingField; //Field offset: 0x2A8
	private PickingMode m_PickingMode; //Field offset: 0x2AC
	private LayoutNode m_LayoutNode; //Field offset: 0x2B0
	internal ComputedStyle m_Style; //Field offset: 0x2E0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleVariableContext variableContext; //Field offset: 0x330
	internal int inheritedStylesHash; //Field offset: 0x338
	internal readonly uint controlid; //Field offset: 0x33C
	internal int imguiContainerDescendantCount; //Field offset: 0x340
	private bool m_EnabledSelf; //Field offset: 0x344
	private LanguageDirection m_LanguageDirection; //Field offset: 0x348
	private LanguageDirection m_LocalLanguageDirection; //Field offset: 0x34C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<MeshGenerationContext> <generateVisualContent>k__BackingField; //Field offset: 0x350
	private RenderTargetMode m_SubRenderTargetMode; //Field offset: 0x358
	private Material m_defaultMaterial; //Field offset: 0x360
	private List<IValueAnimationUpdate> m_RunningAnimations; //Field offset: 0x368
	private object m_DataSource; //Field offset: 0x370
	private PropertyPath m_DataSourcePath; //Field offset: 0x378
	private List<Binding> m_Bindings; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x410
	private readonly int m_TrickleDownHandleEventCategories; //Field offset: 0x418
	private readonly int m_BubbleUpHandleEventCategories; //Field offset: 0x41C
	private int m_BubbleUpEventCallbackCategories; //Field offset: 0x420
	private int m_TrickleDownEventCallbackCategories; //Field offset: 0x424
	private int m_EventInterestSelfCategories; //Field offset: 0x428
	private int m_CachedEventInterestParentCategories; //Field offset: 0x42C
	private uint m_NextParentCachedVersion; //Field offset: 0x430
	private uint m_NextParentRequiredVersion; //Field offset: 0x434
	private VisualElement m_CachedNextParentWithEventInterests; //Field offset: 0x438
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Hierarchy <hierarchy>k__BackingField; //Field offset: 0x440
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isRootVisualContainer>k__BackingField; //Field offset: 0x448
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <cacheAsBitmap>k__BackingField; //Field offset: 0x449
	private VisualElement m_PhysicalParent; //Field offset: 0x450
	private VisualElement m_LogicalParent; //Field offset: 0x458
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement, Int32> elementAdded; //Field offset: 0x460
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement> elementRemoved; //Field offset: 0x468
	private List<VisualElement> m_Children; //Field offset: 0x470
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseVisualElementPanel <elementPanel>k__BackingField; //Field offset: 0x478
	private VisualTreeAsset m_VisualTreeAssetSource; //Field offset: 0x480
	internal InlineStyleAccess inlineStyleAccess; //Field offset: 0x488
	internal ResolvedStyleAccess resolvedStyleAccess; //Field offset: 0x490
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> styleSheetList; //Field offset: 0x498
	private TypeData m_TypeData; //Field offset: 0x4A0

	internal event Action<VisualElement, Int32> elementAdded
	{
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal remove { } //Length: 160
	}

	internal event Action<VisualElement> elementRemoved
	{
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		internal remove { } //Length: 160
	}

	internal bool areAncestorsAndSelfDisplayed
	{
		[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 88
	}

	internal Rect boundingBox
	{
		[CalledBy(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabLayout), Member = "GetHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TabLayout), Member = "GetWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabDragger), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabDragger), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBoxInParentSpace", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		internal get { } //Length: 66
	}

	internal bool boundingBoxDirtiedSinceLastLayoutPass
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	private Rect boundingBoxInParentSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 81
	}

	public virtual bool canGrabFocus
	{
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 258
	}

	[CreateProperty(ReadOnly = True)]
	public int childCount
	{
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(TwoPaneSplitViewOrientation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 115
	}

	internal List<String> classList
	{
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 177
	}

	internal ComputedStyle computedStyle
	{
		[CallerCount(Count = 184)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	internal int containedPointerIds
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public override VisualElement contentContainer
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CreateProperty(ReadOnly = True)]
	public Rect contentRect
	{
		[CallerCount(Count = 38)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		 get { } //Length: 709
	}

	public ICustomStyle customStyle
	{
		[CalledBy(Type = typeof(Vector4Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CustomStyleAccess), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 142
	}

	[CreateProperty]
	public object dataSource
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 221
	}

	[CreateProperty]
	public PropertyPath dataSourcePath
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 105
		[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 528
	}

	internal Material defaultMaterial
	{
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 10
	}

	internal bool disableClipping
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	[CreateProperty]
	public bool disablePlayModeTint
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	internal bool disableRendering
	{
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 76
	}

	internal BaseVisualElementPanel elementPanel
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	public bool enabledInHierarchy
	{
		[CalledBy(Type = typeof(Clickable), Member = "OnTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerState)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "PasteActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CalledBy(Type = typeof(TextElement), Member = "CopyActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CalledBy(Type = typeof(TextElement), Member = "CutActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
		[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.get_isReadOnly", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "Disabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		 get { } //Length: 16
	}

	[CreateProperty]
	public bool enabledSelf
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 set { } //Length: 142
	}

	internal bool enableViewDataPersistence
	{
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
		[CallerCount(Count = 6)]
		internal get { } //Length: 9
	}

	internal int eventInterestParentCategories
	{
		[CalledBy(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "get_nextParentWithEventInterests", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 268
	}

	public IExperimentalFeatures experimental
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual FocusController focusController
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 186
	}

	internal string fullTypeName
	{
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[Calls(Type = typeof(TypeData), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 35
	}

	public Action<MeshGenerationContext> generateVisualContent
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 19
	}

	private bool has3DRotation
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 222
	}

	internal bool has3DTransform
	{
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "GetParentMustDirtyFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElementFlags))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 319
	}

	private bool has3DTranslation
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 53
	}

	internal bool hasCompletedAnimations
	{
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 78
	}

	internal bool hasDefaultRotationAndScale
	{
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 276
	}

	internal bool hasInlineStyle
	{
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 12
	}

	internal bool hasRunningAnimations
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 78
	}

	public Hierarchy hierarchy
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal bool isBoundingBoxDirty
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		internal set { } //Length: 25
	}

	internal bool isCompositeRoot
	{
		[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Focusable), Member = "set_excludeFromFocusRing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	internal bool isEventInterestParentCategoriesDirty
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		internal set { } //Length: 25
	}

	internal bool isLayoutManual
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		private set { } //Length: 25
	}

	internal bool isLocalBounds3DDirty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	private bool isParentEnabledInHierarchy
	{
		[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 103
	}

	internal bool isRootVisualContainer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool isWorldBoundingBoxDirty
	{
		[CallerCount(Count = 0)]
		internal set { } //Length: 25
	}

	internal bool isWorldBoundingBoxOrDependenciesDirty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool isWorldClipDirty
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	internal bool isWorldTransformDirty
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	internal bool isWorldTransformInverseDirty
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 25
	}

	internal bool isWorldTransformInverseOrDependenciesDirty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	public VisualElement Item
	{
		[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "IdentifyLeftAndRightPane", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "RaiseColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
		[CallsDeduplicatedMethods(Count = 3)]
		 get { } //Length: 142
	}

	[CreateProperty]
	public LanguageDirection languageDirection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 137
	}

	[CreateProperty(ReadOnly = True)]
	public internal Rect layout
	{
		[CallerCount(Count = 145)]
		[Calls(Type = typeof(LayoutNode), Member = "get_IsUndefined", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutX", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutY", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(LayoutNode), Member = "get_LayoutHeight", ReturnType = typeof(float))]
		 get { } //Length: 229
		[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 16)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 2080
	}

	internal LayoutNode layoutNode
	{
		[CallerCount(Count = 92)]
		internal get { } //Length: 10
	}

	[CreateProperty(ReadOnly = True)]
	public Rect localBound
	{
		[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "GetHoverBarTopPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "<ApplyDragAndDropUI>g__GeometryChangedCallback|31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 104
	}

	internal Bounds localBounds3D
	{
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
		internal get { } //Length: 149
	}

	internal LanguageDirection localLanguageDirection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_languageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 259
	}

	[CreateProperty]
	public string name
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 71)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 183
	}

	internal bool needs3DBounds
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	internal VisualElement nextParentWithEventInterests
	{
		[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 7)]
		internal get { } //Length: 469
	}

	protected Rect paddingRect
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 418
	}

	[CreateProperty(ReadOnly = True)]
	public IPanel panel
	{
		[CallerCount(Count = 98)]
		 get { } //Length: 10
	}

	public VisualElement parent
	{
		[CallerCount(Count = 49)]
		 get { } //Length: 10
	}

	[CreateProperty]
	public PickingMode pickingMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 57)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 161
	}

	internal Color playModeTintColor
	{
		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		internal get { } //Length: 73
	}

	private Vector3 positionWithLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		private get { } //Length: 146
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal PseudoStates pseudoStates
	{
		[CallerCount(Count = 54)]
		internal get { } //Length: 9
		[CallerCount(Count = 47)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal set { } //Length: 110
	}

	internal bool receivesHierarchyGeometryChangedEvents
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	internal Rect rect
	{
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 54
	}

	internal RenderHints renderHints
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal set { } //Length: 95
	}

	internal bool requireMeasureFunction
	{
		[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LayoutNode), Member = "get_IsMeasureDefined", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutMeasureFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutNode), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 251
	}

	[CreateProperty]
	public IResolvedStyle resolvedStyle
	{
		[CallerCount(Count = 269)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 133
	}

	public float scaledPixelsPerPoint
	{
		[CalledBy(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Texture2D>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&), typeof(List`1<Single>&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
		 get { } //Length: 159
	}

	[Obsolete("scaledPixelsPerPoint_noChecks is deprecated. Use scaledPixelsPerPoint instead.")]
	internal float scaledPixelsPerPoint_noChecks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
		internal get { } //Length: 95
	}

	public IVisualElementScheduler schedule
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CreateProperty]
	public IStyle style
	{
		[CallerCount(Count = 252)]
		[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 121
	}

	internal IStylePropertyAnimations styleAnimation
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool styleInitialized
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		internal get { } //Length: 9
		[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	[CreateProperty(ReadOnly = True)]
	public VisualElementStyleSheetSet styleSheets
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 39
	}

	internal RenderTargetMode subRenderTargetMode
	{
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 9
	}

	[CreateProperty]
	public string tooltip
	{
		[CalledBy(Type = typeof(BaseField`1), Member = "ComputeTooltipRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(BaseField`1), Member = "GetTooltipRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		 get { } //Length: 137
		[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextElement), Member = "UpdateTooltip", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 559
	}

	public ITransform transform
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	private TypeData typeData
	{
		[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 342
	}

	internal string typeName
	{
		[CalledBy(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
		[Calls(Type = typeof(TypeData), Member = "get_typeName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 35
	}

	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	private override Align UnityEngine.UIElements.IResolvedStyle.alignContent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 79
	}

	private override Align UnityEngine.UIElements.IResolvedStyle.alignItems
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Align UnityEngine.UIElements.IResolvedStyle.alignSelf
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 215
	}

	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 215
	}

	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 215
	}

	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 197
	}

	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 213
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.bottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.color
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.flexGrow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.flexShrink
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.fontSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.height
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.left
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.letterSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.marginTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.opacity
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.paddingTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Position UnityEngine.UIElements.IResolvedStyle.position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.right
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Rotate UnityEngine.UIElements.IResolvedStyle.rotate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 217
	}

	private override Scale UnityEngine.UIElements.IResolvedStyle.scale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.top
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 215
	}

	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDelay
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDuration
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.transitionProperty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Vector3 UnityEngine.UIElements.IResolvedStyle.translate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 215
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.unityEditorTextRenderingMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Font UnityEngine.UIElements.IResolvedStyle.unityFont
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 197
	}

	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.unitySliceScale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceTop
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override SliceType UnityEngine.UIElements.IResolvedStyle.unitySliceType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.unityTextGenerator
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 207
	}

	private override float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override Visibility UnityEngine.UIElements.IResolvedStyle.visibility
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.width
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override float UnityEngine.UIElements.IResolvedStyle.wordSpacing
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 82
	}

	private override int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	private override int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	private override Vector3 UnityEngine.UIElements.ITransform.position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 227
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private set { } //Length: 376
	}

	private override Vector3 UnityEngine.UIElements.ITransform.scale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 276
	}

	[CreateProperty]
	public UsageHints usageHints
	{
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
		[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		 set { } //Length: 509
	}

	[CreateProperty]
	public object userData
	{
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
		 get { } //Length: 149
		[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
		[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
		[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		 set { } //Length: 324
	}

	[CreateProperty]
	public string viewDataKey
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EditorPanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 197
	}

	[CreateProperty]
	public bool visible
	{
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 88
		[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "SetToggleVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseCompositeField`3), Member = "GetSpacer", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 372
	}

	[CreateProperty(ReadOnly = True)]
	public internal VisualTreeAsset visualTreeAssetSource
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	public Rect worldBound
	{
		[CallerCount(Count = 69)]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
		 get { } //Length: 259
	}

	internal Rect worldBoundingBox
	{
		[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection)}, ReturnType = typeof(Focusable))]
		[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 177
	}

	internal Rect worldClip
	{
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 66
	}

	internal bool worldClipIsInfinite
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
		internal get { } //Length: 52
	}

	internal Rect worldClipMinusGroup
	{
		[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
		internal get { } //Length: 66
	}

	[CreateProperty(ReadOnly = True)]
	public Matrix4x4 worldTransform
	{
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMGUIContainer), typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		 get { } //Length: 107
	}

	internal Matrix4x4 worldTransformInverse
	{
		[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
		internal get { } //Length: 126
	}

	internal Matrix4x4 worldTransformRef
	{
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
		internal get { } //Length: 48
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 28)]
	private static VisualElement() { }

	[CallerCount(Count = 113)]
	[Calls(Type = typeof(InitialStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[Calls(Type = typeof(Focusable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateNode", ReturnType = typeof(LayoutNode))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestSelfCategories", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public VisualElement() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <CalculateConservativeBounds>g__IsNaN|732_0(Vector3 v) { }

	[CallerCount(Count = 120)]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Add(VisualElement child) { }

	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void add_elementAdded(Action<VisualElement, Int32> value) { }

	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void add_elementRemoved(Action<VisualElement> value) { }

	[CalledBy(Type = typeof(CallbackEventHandler), Member = "AddEventCategories", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateEventInterestSelfCategories", ReturnType = typeof(void))]
	internal void AddEventCallbackCategories(int eventCategories, TrickleDown trickleDown) { }

	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Panel), Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void AddStyleSheetPath(string sheetPath) { }

	[CallerCount(Count = 356)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void AddToClassList(string className) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutMeasureFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	private void AssignMeasureFunction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 58)]
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	private void AttachDataSource() { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void BringToFront() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	internal static Bounds CalculateConservativeBounds(ref Matrix4x4 matrix, Bounds bounds) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	private void ChangeIMGUIContainerCount(int delta) { }

	[CalledBy(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ClearProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PropertyName), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private static void CheckUserKeyArgument(PropertyName key) { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Children", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "Children", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[CallsDeduplicatedMethods(Count = 3)]
	public IEnumerable<VisualElement> Children() { }

	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnNavigationMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "get_showBorder", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "AlignLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MinMaxSlider), Member = "GetNavigationState", ReturnType = "UnityEngine.UIElements.MinMaxSlider+DragState")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementUtils+<>c", Member = "<AssignInspectorStyleIfNecessary>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ClassListContains(string cls) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clear() { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 12)]
	internal void ClearManualLayout() { }

	[CalledBy(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "DestroyHeaderContent", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	internal bool ClearProperty(PropertyName key) { }

	[CallerCount(Count = 0)]
	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	[CalledBy(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClickDetector), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_closeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveDragHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveCloseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabCloseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	public bool Contains(VisualElement child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	public override bool ContainsPoint(Vector2 localPoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void CreateBindingRequests() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	private void DetachDataSource() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private void DirtyNextParentWithEventInterests() { }

	[CallerCount(Count = 0)]
	protected private override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[CalledBy(Type = typeof(MultiColumnController), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	public VisualElement ElementAt(int index) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "HandleFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal VisualElement ElementAtTreePath(List<Int32> childIndexes) { }

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void EnableInClassList(string className, bool enable) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	internal void EnsureWorldTransformAndClipUpToDate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "DestroyNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	private void FinalizeLayout() { }

	[CalledBy(Type = typeof(ClickDetector), Member = "SendClickEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public VisualElement FindCommonAncestor(VisualElement other) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal bool FindElementInTree(VisualElement element, List<Int32> outChildIndexes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "Focus", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Focus() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void GatherAllChildren(List<VisualElement> elements) { }

	[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	internal bool get_areAncestorsAndSelfDisplayed() { }

	[CalledBy(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabLayout), Member = "GetHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TabLayout), Member = "GetWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBoxInParentSpace", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	internal Rect get_boundingBox() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal bool get_boundingBoxDirtiedSinceLastLayoutPass() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	private Rect get_boundingBoxInParentSpace() { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool get_canGrabFocus() { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "GetLargestItemWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(TwoPaneSplitViewOrientation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public int get_childCount() { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "UpdateBackground", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "UpdateButtonHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<String> get_classList() { }

	[CallerCount(Count = 184)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ComputedStyle get_computedStyle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_containedPointerIds() { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public override VisualElement get_contentContainer() { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public Rect get_contentRect() { }

	[CalledBy(Type = typeof(Vector4Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T0&", "T1&", "T2&", typeof(BindingId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CustomStyleAccess), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.StyleSheets.StylePropertyValue>), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ICustomStyle get_customStyle() { }

	[CallerCount(Count = 0)]
	public object get_dataSource() { }

	[CallerCount(Count = 0)]
	public PropertyPath get_dataSourcePath() { }

	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal Material get_defaultMaterial() { }

	[CallerCount(Count = 0)]
	internal bool get_disableClipping() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_disablePlayModeTint() { }

	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal bool get_disableRendering() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal BaseVisualElementPanel get_elementPanel() { }

	[CalledBy(Type = typeof(Clickable), Member = "OnTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicCallbackList), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "Disabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FocusController), Member = "GetFocusableParentForPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetFocusChangeDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(FocusChangeDirection))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.get_isReadOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "CutActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(TextElement), Member = "CopyActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(TextElement), Member = "PasteActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(Status))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	public bool get_enabledInHierarchy() { }

	[CallerCount(Count = 0)]
	public bool get_enabledSelf() { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "ExpandItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "CollapseItemByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	internal bool get_enableViewDataPersistence() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_nextParentWithEventInterests", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	internal int get_eventInterestParentCategories() { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public IExperimentalFeatures get_experimental() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual FocusController get_focusController() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(TypeData), Member = "get_fullTypeName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string get_fullTypeName() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Action<MeshGenerationContext> get_generateVisualContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_has3DRotation() { }

	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "GetParentMustDirtyFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(VisualElementFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_has3DTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[ContainsUnimplementedInstructions]
	private bool get_has3DTranslation() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_hasCompletedAnimations() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[ContainsUnimplementedInstructions]
	internal bool get_hasDefaultRotationAndScale() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool get_hasInlineStyle() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_hasRunningAnimations() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Hierarchy get_hierarchy() { }

	[CallerCount(Count = 0)]
	internal bool get_isBoundingBoxDirty() { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "set_excludeFromFocusRing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Focusable), Member = "GetFirstFocusableChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(FocusController), Member = "GetRetargetedFocusedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(FocusController), Member = "GetFocusTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.FocusController+FocusedElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "BuildRingForScopeRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementFocusRing+FocusRingRecord>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	internal bool get_isCompositeRoot() { }

	[CallerCount(Count = 0)]
	internal bool get_isEventInterestParentCategoriesDirty() { }

	[CallerCount(Count = 0)]
	internal bool get_isLayoutManual() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isLocalBounds3DDirty() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	private bool get_isParentEnabledInHierarchy() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_isRootVisualContainer() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_isWorldClipDirty() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_isWorldTransformDirty() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "OnFocusIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RadioButtonGroup), Member = "RebuildRadioButtonsFromChoices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "IdentifyLeftAndRightPane", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "RaiseColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 3)]
	public VisualElement get_Item(int key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LanguageDirection get_languageDirection() { }

	[CallerCount(Count = 145)]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsUndefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutX", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutY", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(LayoutNode), Member = "get_LayoutHeight", ReturnType = typeof(float))]
	public Rect get_layout() { }

	[CallerCount(Count = 92)]
	internal LayoutNode get_layoutNode() { }

	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "GetHoverBarTopPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAtElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "PlaceHoverBarAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "<ApplyDragAndDropUI>g__GeometryChangedCallback|31_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	public Rect get_localBound() { }

	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "GetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(WorldSpaceData))]
	internal Bounds get_localBounds3D() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal LanguageDirection get_localLanguageDirection() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_needs3DBounds() { }

	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateEventInterestParentCategories", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 7)]
	internal VisualElement get_nextParentWithEventInterests() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Spacing), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Spacing)}, ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected Rect get_paddingRect() { }

	[CallerCount(Count = 98)]
	public IPanel get_panel() { }

	[CallerCount(Count = 49)]
	public VisualElement get_parent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PickingMode get_pickingMode() { }

	[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	internal Color get_playModeTintColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	private Vector3 get_positionWithLayout() { }

	[CallerCount(Count = 54)]
	internal PseudoStates get_pseudoStates() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal bool get_receivesHierarchyGeometryChangedEvents() { }

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_rect() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal RenderHints get_renderHints() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal bool get_requireMeasureFunction() { }

	[CallerCount(Count = 269)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IResolvedStyle get_resolvedStyle() { }

	[CalledBy(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateDragElementPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Texture2D>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&), typeof(List`1<Single>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextElement), Member = "ElideText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(TextOverflowPosition)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextElement), Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>)}, ReturnType = typeof(ComputedStyle))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	public float get_scaledPixelsPerPoint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	internal float get_scaledPixelsPerPoint_noChecks() { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public IVisualElementScheduler get_schedule() { }

	[CallerCount(Count = 252)]
	[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public IStyle get_style() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal IStylePropertyAnimations get_styleAnimation() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	internal bool get_styleInitialized() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public VisualElementStyleSheetSet get_styleSheets() { }

	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal RenderTargetMode get_subRenderTargetMode() { }

	[CalledBy(Type = typeof(BaseField`1), Member = "ComputeTooltipRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseField`1), Member = "GetTooltipRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	public string get_tooltip() { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public ITransform get_transform() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_fullTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_typeName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private TypeData get_typeData() { }

	[CalledBy(Type = typeof(AncestorFilter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSelectorHelper), Member = "FindMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleMatchingContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_typeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(TypeData), Member = "get_typeName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string get_typeName() { }

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public UsageHints get_usageHints() { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeViewController), Member = "OnToggleValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyboardNavigationOperation)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	public object get_userData() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_viewDataKey() { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabLayout), Member = "GetTabOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "ReevaluateFocus", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_visible() { }

	[CallerCount(Count = 0)]
	public VisualTreeAsset get_visualTreeAssetSource() { }

	[CallerCount(Count = 69)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	public Rect get_worldBound() { }

	[CalledBy(Type = "UnityEngine.UIElements.NavigateFocusRing+FocusableHierarchyTraversal", Member = "ValidateHierarchyTraversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(ChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal Rect get_worldBoundingBox() { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_worldClip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	internal bool get_worldClipIsInfinite() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	internal Rect get_worldClipMinusGroup() { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMGUIContainer), typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	public Matrix4x4 get_worldTransform() { }

	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	internal Matrix4x4 get_worldTransformInverse() { }

	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(VisualElementExtensions), Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	internal Matrix4x4 get_worldTransformRef() { }

	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UnregisterRunningAnimations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "RegisterRunningAnimations", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	private VisualElementAnimationSystem GetAnimationSystem() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool GetCachedNextParentWithEventInterests(out VisualElement nextParent) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal List<String> GetClassesForIteration() { }

	[CalledBy(Type = typeof(TabDragger), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T GetFirstAncestorOfType() { }

	[CalledBy(Type = typeof(ScrollView), Member = "ReadSingleLineHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementUtils), Member = "AssignInspectorStyleIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate) { }

	[CalledBy(Type = typeof(DragEventsProcessor), Member = "GetDropTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DragEventsProcessor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public T GetFirstOfType() { }

	[CalledBy(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	[CalledBy(Type = typeof(TabView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string GetFullHierarchicalViewDataKey() { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal VisualElement GetNextElementDepthFirst() { }

	[CalledBy(Type = typeof(TabView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enableViewDataPersistence", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal T GetOrCreateViewData(object existing, string key) { }

	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private Nullable<Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeTransformMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "Initial", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[ContainsUnimplementedInstructions]
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal VisualElement GetPreviousElementDepthFirst() { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object GetProperty(PropertyName key) { }

	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetNextFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(VisualElementFocusRing), Member = "GetPreviousFocusableInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Focusable))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetRoot() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetRootVisualContainer(bool stopAtNearestRoot = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override Rect GetTooltipRect() { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool HasBubbleUpEventCallbacks(int eventCategories) { }

	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool HasBubbleUpEventInterests(int eventCategories) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool HasBubbleUpHandleEvent(int eventCategories) { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "GetDefaultConfig", ReturnType = typeof(LayoutConfig))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Config", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "SoftReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "AnyPendingBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelChangedEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPanel)}, ReturnType = "T")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	internal bool HasParentEventInterests(int eventCategories) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	internal bool HasParentEventInterests(EventCategory eventCategory) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool HasProperty(PropertyName key) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool HasSelfEventInterests(EventCategory eventCategory) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool HasSelfEventInterests(int eventCategories) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool HasTrickleDownEventCallbacks(int eventCategories) { }

	[CalledBy(Type = typeof(PropagationPaths), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(EventBase), typeof(int)}, ReturnType = typeof(PropagationPaths))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool HasTrickleDownEventInterests(int eventCategories) { }

	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "HandleEventAcrossPropagationPathWithCompatibilityEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool HasTrickleDownHandleEvent(int eventCategories) { }

	[CallerCount(Count = 139)]
	[CallsDeduplicatedMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void IncrementVersion(VersionChangeType changeType) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnControlGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public int IndexOf(VisualElement element) { }

	[CalledBy(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ToggleButtonGroupState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "ReorderTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HelpBox), Member = "UpdateIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HelpBoxMessageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupBox), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseBoolField), Member = "InitLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "UpdateDragHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "AddDragHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Insert(int index, VisualElement element) { }

	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseElementBuilder), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "MoveChildElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "MarkWaitingForLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_cursorColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_selectionColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.ITextEdition.set_placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_displayTooltipWhenElided", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_parseEscapeSequences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_emojiFallbackSupport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "set_enableRichText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateCutRenderChainFlag", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextValueField`1), Member = "StartDragging", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StopDragging", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextValueField`1+TextValueInput", Member = "StartDragging", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MarkDirtyRepaint() { }

	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void MarkRenderHintsClean() { }

	[CallerCount(Count = 0)]
	internal static float Max(float a, float b, float c, float d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Measure(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }

	[CallerCount(Count = 0)]
	internal static float Min(float a, float b, float c, float d) { }

	[CalledBy(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRUtility), Member = "ComputeTransformMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 4)]
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	[CallerCount(Count = 0)]
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	[CallerCount(Count = 0)]
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override void OnViewDataReady() { }

	[CallerCount(Count = 0)]
	internal static void OrderMinMaxBounds(ref Bounds bounds) { }

	[CallerCount(Count = 0)]
	internal static void OrderMinMaxRect(ref Rect rect) { }

	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Foldout), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextField), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void OverwriteFromViewData(object obj, string key) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void PlaceBehind(VisualElement sibling) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "AnyPendingBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ProcessBindingRequests() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 2)]
	private void PropagateCachedNextParentWithEventInterests(VisualElement nextParent, VisualElement stopParent) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabledFromHierarchyPrivate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PropagateEnabledToChildren(bool value) { }

	[CalledBy(Type = typeof(<>c__DisplayClass524_0), Member = "<UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(StyleValues))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValues), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_marginTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_right", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_bottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderRightWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderLeftWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_opacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopRightRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderTopLeftRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomRightRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_borderBottomLeftRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValues), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 62)]
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Register", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "RegisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	private void RegisterRunningAnimations() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "set_closeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveDragHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabDragHandles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "RemoveCloseButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "EnableTabCloseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabView), Member = "OnElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Remove(VisualElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void remove_elementAdded(Action<VisualElement, Int32> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	internal void remove_elementRemoved(Action<VisualElement> value) { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveFromClassList(string className) { }

	[CallerCount(Count = 74)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromHierarchy() { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutNode), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	private void RemoveMeasureFunction() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_maxWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minHeight", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_minWidth", ReturnType = typeof(StyleFloat))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_rotate", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "Initial", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(Rotate), Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	private Quaternion ResolveRotation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_scale", ReturnType = typeof(Scale))]
	[ContainsUnimplementedInstructions]
	private Vector3 ResolveScale() { }

	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_transformOrigin", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transformOrigin", ReturnType = typeof(TransformOrigin))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal Vector3 ResolveTransformOrigin() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(ResolvedStyleAccess), Member = "get_translate", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_positionWithLayout", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedBoundsToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "TransformAlignedRectToParentSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_translate", ReturnType = typeof(Translate))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal Vector3 ResolveTranslate() { }

	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	[CallerCount(Count = 45)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SaveViewData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	internal virtual void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	public virtual void SendEvent(EventBase e) { }

	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SendToBack() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_areAncestorsAndSelfDisplayed(bool value) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateSubTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_boundingBoxDirtiedSinceLastLayoutPass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_containedPointerIds(int value) { }

	[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_dataSource(object value) { }

	[CalledBy(Type = typeof(BaseListViewController), Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_dataSourcePath(PropertyPath value) { }

	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void set_disableClipping(bool value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void set_disablePlayModeTint(bool value) { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "UpdateHierarchyDisplayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_disableRendering(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_elementPanel(BaseVisualElementPanel value) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void set_enabledSelf(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_generateVisualContent(Action<MeshGenerationContext> value) { }

	[CallerCount(Count = 0)]
	internal void set_isBoundingBoxDirty(bool value) { }

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void set_isCompositeRoot(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isEventInterestParentCategoriesDirty(bool value) { }

	[CallerCount(Count = 0)]
	private void set_isLayoutManual(bool value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal void set_isLocalBounds3DDirty(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_isRootVisualContainer(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_isWorldClipDirty(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_isWorldTransformDirty(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_isWorldTransformInverseDirty(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_languageDirection(LanguageDirection value) { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal void set_layout(Rect value) { }

	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_languageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "set_localLanguageDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_localLanguageDirection(LanguageDirection value) { }

	[CallerCount(Count = 71)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_name(string value) { }

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_pickingMode(PickingMode value) { }

	[CallerCount(Count = 47)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void set_pseudoStates(PseudoStates value) { }

	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_receivesHierarchyGeometryChangedEvents(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void set_renderHints(RenderHints value) { }

	[CalledBy(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsMeasureDefined", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutNode), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutMeasureFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal void set_requireMeasureFunction(bool value) { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void set_styleInitialized(bool value) { }

	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateTooltip", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_tooltip(string value) { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTranslate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleScale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	public void set_usageHints(UsageHints value) { }

	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "InitExpandHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[CalledBy(Type = typeof(Tab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Background)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_userData", ReturnType = typeof(object))]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	public void set_userData(object value) { }

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EditorPanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_viewDataKey(string value) { }

	[CalledBy(Type = typeof(BaseTreeViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableTreeViewItem), Member = "SetToggleVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseCompositeField`3), Member = "GetSpacer", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void set_visible(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	[CalledBy(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EditorPanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal void SetAsNextParentWithEventInterests() { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[Calls(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "CopyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	[CalledBy(Type = typeof(MultiColumnListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "SetDragHandleEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateRemoveButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_allowAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(MenuItem))]
	[CalledBy(Type = typeof(Scroller), Member = "Adjust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(VisualElement), Member = "set_enabledSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void SetEnabled(bool value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "PropagateEnabledToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_isParentEnabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "BlurImmediately", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClickDetector), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GatherAllChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementListPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(VisualElementListPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	internal void SetPanel(BaseVisualElementPanel p) { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VisualElement), Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetPropertyInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetProperty(PropertyName key, object value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "set_userData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.PropertyName, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SetPropertyInternal(PropertyName key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_tooltip", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetTooltip(TooltipEvent e) { }

	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DetermineSelfClipMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(ClipMethod))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[ContainsUnimplementedInstructions]
	internal bool ShouldClip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`4<UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, System.Single, UnityEngine.UIElements.Experimental.StyleValues>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CalledBy(Type = typeof(VisualElement), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues>), typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValueAnimation`1), Member = "set_durationMs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static ValueAnimation<T> StartAnimation(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) { }

	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityOverflowClipBox", ReturnType = typeof(OverflowClipBox))]
	[CallsUnknownMethods(Count = 13)]
	private Rect SubstractBorderPadding(Rect worldRect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Rect), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_dataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "DetachDataSource", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AttachDataSource", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void TrackSource(object previous, object current) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	internal static void TransformAlignedBounds(ref Matrix4x4 matrix, ref Bounds bounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	internal void TransformAlignedBoundsToParentSpace(ref Bounds bounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	[CallerCount(Count = 0)]
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "set_x", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BackgroundSize), Member = "set_y", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertTransformOriginUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertTranslateUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetParentSizeForLengthConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(System.Nullable`1<System.Single>))]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "ConvertUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "OnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetBinding(BindingId bindingId, out Binding binding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValues), Member = "Values", ReturnType = typeof(StyleValueCollection))]
	[Calls(Type = typeof(System.Func`4<UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, System.Single, UnityEngine.UIElements.Experimental.StyleValues>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private override ValueAnimation<StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignItems() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignSelf() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Background UnityEngine.UIElements.IResolvedStyle.get_backgroundImage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionX() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionY() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.get_backgroundRepeat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.get_backgroundSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_flexBasis() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Wrap UnityEngine.UIElements.IResolvedStyle.get_flexWrap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_fontSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Justify UnityEngine.UIElements.IResolvedStyle.get_justifyContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_letterSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Position UnityEngine.UIElements.IResolvedStyle.get_position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Rotate UnityEngine.UIElements.IResolvedStyle.get_rotate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.get_textOverflow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDelay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDuration() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.get_transitionProperty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.get_transitionTimingFunction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.get_unityEditorTextRenderingMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override Font UnityEngine.UIElements.IResolvedStyle.get_unityFont() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.get_unityFontDefinition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override FontStyle UnityEngine.UIElements.IResolvedStyle.get_unityFontStyleAndWeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityParagraphSpacing() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceBottom() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceTop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override SliceType UnityEngine.UIElements.IResolvedStyle.get_unitySliceType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.get_unityTextAlign() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.get_unityTextGenerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.get_unityTextOverflowPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsUnknownMethods(Count = 2)]
	private override float UnityEngine.UIElements.IResolvedStyle.get_wordSpacing() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleScheduledItem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "Resume", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimerStateScheduledItem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Action`1<UnityEngine.UIElements.TimerState>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementScheduledItem), Member = "Resume", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent) { }

	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Unregister", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), "System.Func`4<T, T, Single, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "GetAnimationSystem", ReturnType = typeof(VisualElementAnimationSystem))]
	[Calls(Type = typeof(VisualElementAnimationSystem), Member = "UnregisterAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UnregisterRunningAnimations() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void UpdateBoundingBox() { }

	[CalledBy(Type = typeof(MouseCaptureOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOverEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_cursor", ReturnType = typeof(Cursor))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void UpdateCursorStyle(long eventType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_nextParentWithEventInterests", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_eventInterestParentCategories", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateEventInterestParentCategories() { }

	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AddEventCallbackCategories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateEventInterestSelfCategories() { }

	[CalledBy(Type = typeof(PointerEnterEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerLeaveEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoStateAfterCaptureChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "IsPartOfCapturedChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IEventHandler&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	internal void UpdateHoverPseudoState() { }

	[CalledBy(Type = typeof(PointerCaptureOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCaptureEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateHoverPseudoState", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	internal void UpdateHoverPseudoStateAfterCaptureChange(int pointerId) { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorldSpaceDataStore), Member = "SetWorldSpaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void UpdateLocalBoundsAndPickingBounds3D() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateWorldBoundingBox() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldClipMinusGroup", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldClipIsInfinite", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "EnsureWorldTransformAndClipUpToDate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldClip", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "SubstractBorderPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWorldClip() { }

	[CalledBy(Type = typeof(ReusableCollectionItem), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SubstractBorderPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransformInverse", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = typeof(VisualElement), Member = "EnsureWorldTransformAndClipUpToDate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateWorldBoundingBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(ReusableListViewItem), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "MultiplyMatrix34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateWorldTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse3DAffine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	internal void UpdateWorldTransformInverse() { }

	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterRunningAnimations", ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelChangedEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(IPanel)}, ReturnType = "T")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

}


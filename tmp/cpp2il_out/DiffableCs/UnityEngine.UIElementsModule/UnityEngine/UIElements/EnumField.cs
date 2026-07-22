namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class EnumField : BaseField<Enum>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventCallback<MouseDownEvent> <>9__31_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.ctor>b__31_0(MouseDownEvent e) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Enum>
	{
		private UxmlTypeAttributeDescription<Enum> m_Type; //Field offset: 0x98
		private UxmlStringAttributeDescription m_Value; //Field offset: 0xA0
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues; //Field offset: 0xA8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumFieldHelpers), Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId textProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x98
	public static readonly string textUssClassName; //Field offset: 0xA0
	public static readonly string arrowUssClassName; //Field offset: 0xA8
	public static readonly string labelUssClassName; //Field offset: 0xB0
	public static readonly string inputUssClassName; //Field offset: 0xB8
	private Type m_EnumType; //Field offset: 0x538
	private bool m_IncludeObsoleteValues; //Field offset: 0x540
	private TextElement m_TextElement; //Field offset: 0x548
	private VisualElement m_ArrowElement; //Field offset: 0x550
	private EnumData m_EnumData; //Field offset: 0x558
	internal Func<IGenericMenu> createMenuCallback; //Field offset: 0x598

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool includeObsoleteValues
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	public string text
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	private static EnumField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Enum)}, ReturnType = typeof(void))]
	public EnumField() { }

	[CalledBy(Type = typeof(EnumField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public EnumField(string label, Enum defaultValue = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <ShowMenu>b__42_0(object contentView) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void ChangeValueFromMenu(object menuItem) { }

	[CalledBy(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ContainsPointer(int pointerId) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_includeObsoleteValues() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_text() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Init(Enum defaultValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	[CalledBy(Type = typeof(EnumField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Enum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(EnumField), Member = "PopulateDataFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Initialize(Enum defaultValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "ShowMenu", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "ProcessPointerDown", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.EnumDataUtility", Member = "GetCachedEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "UnityEngine.EnumDataUtility+CachedType", typeof(System.Func`2<System.String, System.String>)}, ReturnType = "UnityEngine.EnumData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void PopulateDataFromType(Type enumType) { }

	[CalledBy(Type = typeof(EnumField), Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EnumField), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Object>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual void SetValueWithoutNotify(Enum newValue) { }

	[CalledBy(Type = typeof(EnumField), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void ShowMenu() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumField), Member = "UpdateValueLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UpdateMixedValueContent() { }

	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnumField), Member = "UpdateMixedValueContent", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateValueLabel(Enum value) { }

}


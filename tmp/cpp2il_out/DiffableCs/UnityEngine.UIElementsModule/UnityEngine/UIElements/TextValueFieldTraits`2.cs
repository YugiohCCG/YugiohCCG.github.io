namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Obsolete("TextValueFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class TextValueFieldTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
	private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
	private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
	private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0

	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseFieldTraits`2<System.Double, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public TextValueFieldTraits`2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "set_isReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}


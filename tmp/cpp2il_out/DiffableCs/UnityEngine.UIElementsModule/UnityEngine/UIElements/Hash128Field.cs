namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Hash128Field : TextInputBaseField<Hash128>
{
	private class Hash128Input : TextInputBase<Hash128>
	{

		protected string allowedCharacters
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal Hash128Input() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = "AcceptCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal virtual bool AcceptCharacter(char c) { }

		[CallerCount(Count = 0)]
		protected string get_allowedCharacters() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal static Hash128 Parse(string str) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		protected virtual Hash128 StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Hash128Field, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<UnityEngine.Hash128, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	public virtual Hash128 value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 92
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Hash128>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 185
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static Hash128Field() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	public Hash128Field() { }

	[CalledBy(Type = typeof(Hash128Field), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char), typeof(UnityEngine.UIElements.TextInputBaseField`1+TextInputBase<UnityEngine.Hash128>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public Hash128Field(string label, int maxLength = -1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Hash128 get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_isReadOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase`1), Member = "TypeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInputBase), Member = "UpdateTextFromValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Hash128>), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void set_value(Hash128 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void SetValueWithoutNotify(Hash128 newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual Hash128 StringToValue(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual void UpdateTextFromValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<UnityEngine.Hash128>), Member = "get_text", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void UpdateValueFromText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	protected virtual string ValueToString(Hash128 value) { }

}


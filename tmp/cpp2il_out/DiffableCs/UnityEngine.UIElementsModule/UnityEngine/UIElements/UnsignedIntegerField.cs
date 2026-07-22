namespace UnityEngine.UIElements;

public class UnsignedIntegerField : TextValueField<UInt32>
{
	private class UnsignedIntegerInput : TextValueInput<UInt32>
	{

		protected virtual string allowedCharacters
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 79
		}

		private UnsignedIntegerField parentUnsignedIntegerField
		{
			[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 113
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal UnsignedIntegerInput() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(UnsignedIntegerInput), Member = "get_parentUnsignedIntegerField", ReturnType = typeof(UnsignedIntegerField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.UInt32>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mathf), Member = "ClampToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

		[CallerCount(Count = 0)]
		protected virtual string get_allowedCharacters() { }

		[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 1)]
		private UnsignedIntegerField get_parentUnsignedIntegerField() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsignedIntegerInput), Member = "get_parentUnsignedIntegerField", ReturnType = typeof(UnsignedIntegerField))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual uint StringToValue(string str) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		protected virtual string ValueToString(uint v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : TextValueFieldTraits<UInt32, UxmlUnsignedIntAttributeDescription>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.UInt32, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private UnsignedIntegerInput integerInput
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 122
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static UnsignedIntegerField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public UnsignedIntegerField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public UnsignedIntegerField(string label, int maxLength = 1000) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	internal virtual bool CanTryParse(string textString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private UnsignedIntegerInput get_integerInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual uint StringToValue(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual string ValueToString(uint v) { }

}


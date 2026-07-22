namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FloatField : TextValueField<Single>
{
	private class FloatInput : TextValueInput<Single>
	{

		protected virtual string allowedCharacters
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 78
		}

		private FloatField parentFloatField
		{
			[CalledBy(Type = typeof(FloatInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(FloatInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 113
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Single>+TextValueInput<Single>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal FloatInput() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateFloatDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Mathf), Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[Calls(Type = typeof(FloatInput), Member = "get_parentFloatField", ReturnType = typeof(FloatField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Single>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mathf), Member = "ClampToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

		[CallerCount(Count = 0)]
		protected virtual string get_allowedCharacters() { }

		[CalledBy(Type = typeof(FloatInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FloatInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 1)]
		private FloatField get_parentFloatField() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatInput), Member = "get_parentFloatField", ReturnType = typeof(FloatField))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual float StringToValue(string str) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		protected virtual string ValueToString(float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : TextValueFieldTraits<Single, UxmlFloatAttributeDescription>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.Single, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private FloatInput floatInput
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 122
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static FloatField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Single>+TextValueInput<Single>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Single>+TextValueInput<Single>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Single>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public FloatField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Single>+TextValueInput<Single>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Single>+TextValueInput<Single>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Single>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public FloatField(string label, int maxLength = 1000) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	internal virtual bool CanTryParse(string textString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private FloatInput get_floatInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float StringToValue(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextValueField`1), Member = "UpdateValueFromText", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual void UpdateValueFromText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual string ValueToString(float v) { }

}


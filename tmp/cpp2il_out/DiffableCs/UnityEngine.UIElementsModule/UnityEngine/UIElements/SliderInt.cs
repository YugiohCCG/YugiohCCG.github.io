namespace UnityEngine.UIElements;

public class SliderInt : BaseSlider<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Int32, UxmlIntAttributeDescription>
	{
		private UxmlIntAttributeDescription m_LowValue; //Field offset: 0xA0
		private UxmlIntAttributeDescription m_HighValue; //Field offset: 0xA8
		private UxmlIntAttributeDescription m_PageSize; //Field offset: 0xB0
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0xB8
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0xC0
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0xC8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 13)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_inverted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	public virtual float pageSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseSlider`1), Member = "get_pageSize", ReturnType = typeof(float))]
		 get { } //Length: 57
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 142
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static SliderInt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public SliderInt() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_inverted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_direction", ReturnType = typeof(SliderDirection))]
	[Calls(Type = typeof(BaseSlider`1), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "GetClosestPowerOfTen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseSlider`1), Member = "RoundToMultipleOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual void ComputeValueFromKey(SliderKey<Int32> sliderKey, bool isShift) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_pageSize", ReturnType = typeof(float))]
	public virtual float get_pageSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual int ParseStringToValue(string previousValue, string newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void set_pageSize(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual int SliderLerpUnclamped(int a, int b, float interpolant) { }

	[CallerCount(Count = 0)]
	internal virtual float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	internal virtual int SliderRange() { }

}


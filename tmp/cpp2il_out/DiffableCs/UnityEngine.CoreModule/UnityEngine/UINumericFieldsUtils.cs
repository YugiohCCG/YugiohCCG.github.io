namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal static class UINumericFieldsUtils
{
	public static readonly string k_AllowedCharactersForFloat; //Field offset: 0x0
	public static readonly string k_AllowedCharactersForInt; //Field offset: 0x8
	public static readonly string k_DoubleFieldFormatString; //Field offset: 0x10
	public static readonly string k_FloatFieldFormatString; //Field offset: 0x18
	public static readonly string k_IntFieldFormatString; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static UINumericFieldsUtils() { }

	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryConvertStringToDouble(string str, out double value, out Expression expr) { }

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out Expression expression) { }

	[CalledBy(Type = "UnityEngine.UIElements.FloatField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ParseStringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out Expression expression) { }

	[CalledBy(Type = "UnityEngine.UIElements.IntegerField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ParseStringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out Expression expression) { }

	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	public static bool TryConvertStringToLong(string str, out long value, out Expression expr) { }

	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out Expression expression) { }

	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out Expression expression) { }

	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	public static bool TryConvertStringToULong(string str, out ulong value, out Expression expr) { }

	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out Expression expression) { }

}


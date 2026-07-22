namespace UnityEngine.UIElements.StyleSheets;

[VisibleToOtherModules]
internal static class ShorthandApplicator
{
	private static List<TimeValue> s_TransitionDelayList; //Field offset: 0x0
	private static List<TimeValue> s_TransitionDurationList; //Field offset: 0x8
	private static List<StylePropertyName> s_TransitionPropertyList; //Field offset: 0x10
	private static List<EasingFunction> s_TransitionTimingFunctionList; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static ShorthandApplicator() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(List`1<TimeValue>&), typeof(List`1<TimeValue>&), typeof(List`1<StylePropertyName>&), typeof(List`1<EasingFunction>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(BackgroundPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPositionKeyword)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = "ToLength", ReturnType = typeof(Length))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 2)]
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyFlex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "Auto", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueKeyword)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StylePropertyUtil), Member = "TryGetEnumIntValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueKeyword)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TimeValue))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue>& outDelay, out List<TimeValue>& outDuration, out List<StylePropertyName>& outProperty, out List<EasingFunction>& outTimingFunction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

}


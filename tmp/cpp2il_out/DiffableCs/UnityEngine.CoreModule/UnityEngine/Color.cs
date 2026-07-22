namespace UnityEngine;

[DefaultMember("Item")]
[NativeClass("ColorRGBAf")]
[NativeHeader("Runtime/Math/Color.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Color : IEquatable<Color>, IFormattable
{
	public float r; //Field offset: 0x0
	public float g; //Field offset: 0x4
	public float b; //Field offset: 0x8
	public float a; //Field offset: 0xC

	public static Color black
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
	}

	public static Color blue
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 23
	}

	public static Color clear
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public static Color cyan
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 31
	}

	public Color gamma
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "LinearToGammaSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		 get { } //Length: 117
	}

	public static Color gray
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 31
	}

	public static Color green
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 23
	}

	public static Color grey
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 31
	}

	public Color linear
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		 get { } //Length: 117
	}

	public static Color magenta
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
	}

	public float maxColorComponent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 35
	}

	public static Color red
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 23
	}

	public static Color white
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 31
	}

	public static Color yellow
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 31
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Color(float r, float g, float b, float a) { }

	[CallerCount(Count = 0)]
	public Color(float r, float g, float b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool Equals(Color other) { }

	[CallerCount(Count = 0)]
	public static Color get_black() { }

	[CallerCount(Count = 0)]
	public static Color get_blue() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public static Color get_clear() { }

	[CallerCount(Count = 0)]
	public static Color get_cyan() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LinearToGammaSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Color get_gamma() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Color get_gray() { }

	[CallerCount(Count = 0)]
	public static Color get_green() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Color get_grey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public Color get_linear() { }

	[CallerCount(Count = 0)]
	public static Color get_magenta() { }

	[CallerCount(Count = 0)]
	public float get_maxColorComponent() { }

	[CallerCount(Count = 0)]
	public static Color get_red() { }

	[CallerCount(Count = 0)]
	public static Color get_white() { }

	[CallerCount(Count = 0)]
	public static Color get_yellow() { }

	[CalledBy(Type = "UnityEngine.UIElements.InheritedData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.RareData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleColor", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextCoreSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AttachmentDescriptor), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisibleLight), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Color Lerp(Color a, Color b, float t) { }

	[CallerCount(Count = 0)]
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Color op_Addition(Color a, Color b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Color lhs, Color rhs) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public static Color op_Implicit(Vector4 v) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public static Vector4 op_Implicit(Color c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Color lhs, Color rhs) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static Color op_Multiply(Color a, float b) { }

	[CallerCount(Count = 0)]
	public static Color op_Multiply(Color a, Color b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Color op_Subtraction(Color a, Color b) { }

	[CallerCount(Count = 0)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Color RGBMultiplied(float multiplier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}


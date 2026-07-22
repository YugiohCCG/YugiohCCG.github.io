namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector2 : IEquatable<Vector2>, IFormattable
{
	private static readonly Vector2 zeroVector; //Field offset: 0x0
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	private static readonly Vector2 oneVector; //Field offset: 0x8
	private static readonly Vector2 upVector; //Field offset: 0x10
	private static readonly Vector2 downVector; //Field offset: 0x18
	private static readonly Vector2 leftVector; //Field offset: 0x20
	private static readonly Vector2 rightVector; //Field offset: 0x28
	private static readonly Vector2 positiveInfinityVector; //Field offset: 0x30
	private static readonly Vector2 negativeInfinityVector; //Field offset: 0x38
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4

	public static Vector2 down
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public float Item
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 114
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Slider", Member = "UpdateVisuals", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 114
	}

	public static Vector2 left
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public float magnitude
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 178
	}

	public static Vector2 negativeInfinity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public Vector2 normalized
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 147
	}

	public static Vector2 one
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public static Vector2 right
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public float sqrMagnitude
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 24
	}

	public static Vector2 up
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 69
	}

	public static Vector2 zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 68
	}

	[CallerCount(Count = 0)]
	private static Vector2() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public Vector2(float x, float y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float Angle(Vector2 from, Vector2 to) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Distance(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Vector2 other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	public static Vector2 get_down() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetTotalFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public float get_Item(int index) { }

	[CallerCount(Count = 0)]
	public static Vector2 get_left() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_magnitude() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_negativeInfinity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 get_normalized() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_one() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_right() { }

	[CallerCount(Count = 0)]
	public float get_sqrMagnitude() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_up() { }

	[CallerCount(Count = 0)]
	public static Vector2 get_zero() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	[CallerCount(Count = 0)]
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	[CallerCount(Count = 0)]
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	[CallerCount(Count = 0)]
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Normalize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	public static Vector2 op_Division(Vector2 a, float d) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Implicit(Vector3 v) { }

	[CallerCount(Count = 0)]
	public static Vector3 op_Implicit(Vector2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	[CallerCount(Count = 0)]
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	[CallerCount(Count = 0)]
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	[CallerCount(Count = 0)]
	public void Scale(Vector2 scale) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void Set(float newX, float newY) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RectangleParams&", typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "UpdateVisuals", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Item(int index, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}


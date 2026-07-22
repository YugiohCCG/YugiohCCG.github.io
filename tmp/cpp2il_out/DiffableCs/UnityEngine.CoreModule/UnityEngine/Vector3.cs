namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	private static readonly Vector3 zeroVector; //Field offset: 0x0
	private static readonly Vector3 oneVector; //Field offset: 0xC
	private static readonly Vector3 upVector; //Field offset: 0x18
	private static readonly Vector3 downVector; //Field offset: 0x24
	private static readonly Vector3 leftVector; //Field offset: 0x30
	private static readonly Vector3 rightVector; //Field offset: 0x3C
	private static readonly Vector3 forwardVector; //Field offset: 0x48
	private static readonly Vector3 backVector; //Field offset: 0x54
	private static readonly Vector3 positiveInfinityVector; //Field offset: 0x60
	private static readonly Vector3 negativeInfinityVector; //Field offset: 0x6C
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8

	public static Vector3 back
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public static Vector3 down
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public static Vector3 forward
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public float Item
	{
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 129
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 129
	}

	public static Vector3 left
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public float magnitude
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 228
	}

	public Vector3 normalized
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		 get { } //Length: 75
	}

	public static Vector3 one
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public static Vector3 right
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public float sqrMagnitude
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 37
	}

	public static Vector3 up
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public static Vector3 zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 74
	}

	[CallerCount(Count = 0)]
	private static Vector3() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	public Vector3(float x, float y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float Angle(Vector3 from, Vector3 to) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	[CallerCount(Count = 0)]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Distance(Vector3 a, Vector3 b) { }

	[CallerCount(Count = 0)]
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Vector3 other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	public static Vector3 get_back() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_down() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_forward() { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public float get_Item(int index) { }

	[CallerCount(Count = 0)]
	public static Vector3 get_left() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float get_magnitude() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	public Vector3 get_normalized() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_one() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_right() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_sqrMagnitude() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_up() { }

	[CallerCount(Count = 0)]
	public static Vector3 get_zero() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	[CallerCount(Count = 0)]
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Magnitude(Vector3 vector) { }

	[CallerCount(Count = 0)]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	[CallerCount(Count = 0)]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "RayIntersectsRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Ray), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Ray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3), Member = "get_normalized", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderDerivedData", Member = "FromParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OccluderSubviewUpdate&"}, ReturnType = "UnityEngine.Rendering.OccluderDerivedData")]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<OccluderSubviewUpdate>", "Unity.Collections.NativeArray`1<Plane>"}, ReturnType = "UnityEngine.Rendering.OccluderDepthPyramidConstants")]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Ray))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static Vector3 Normalize(Vector3 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeConstantRuntimeResources", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeConstantRuntimeResources", Member = "GenerateSkyDirections", ReturnType = "UnityEngine.Vector3[]")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Normalize() { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static Vector3 op_Division(Vector3 a, float d) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	[CallerCount(Count = 0)]
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	[CallerCount(Count = 0)]
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	[CallerCount(Count = 0)]
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	[CallerCount(Count = 0)]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Scale(Vector3 scale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Item(int index, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float SqrMagnitude(Vector3 vector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}


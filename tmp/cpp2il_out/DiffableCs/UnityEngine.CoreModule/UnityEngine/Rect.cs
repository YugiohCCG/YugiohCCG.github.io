namespace UnityEngine;

[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Rect : IEquatable<Rect>, IFormattable
{
	[NativeName("x")]
	private float m_XMin; //Field offset: 0x0
	[NativeName("y")]
	private float m_YMin; //Field offset: 0x4
	[NativeName("width")]
	private float m_Width; //Field offset: 0x8
	[NativeName("height")]
	private float m_Height; //Field offset: 0xC

	public Vector2 center
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 46
	}

	public float height
	{
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Vector2 max
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 20
		[CallerCount(Count = 0)]
		 set { } //Length: 37
	}

	public Vector2 min
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 20
		[CallerCount(Count = 0)]
		 set { } //Length: 64
	}

	public Vector2 position
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 20
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Vector2 size
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 20
	}

	public float width
	{
		[CallerCount(Count = 47)]
		[DeduplicatedMethod]
		 get { } //Length: 85
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float x
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float xMax
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
		[CallerCount(Count = 0)]
		 set { } //Length: 10
	}

	public float xMin
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 25
	}

	public float y
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float yMax
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 13
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	public float yMin
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
		[CallerCount(Count = 0)]
		 set { } //Length: 27
	}

	public static Rect zero
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Rect(float x, float y, float width, float height) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Rect(Vector2 position, Vector2 size) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Rect(Rect source) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Contains(Vector3 point) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Contains(Vector2 point) { }

	[CalledBy(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraProperties)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisibleLight), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Rect other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	public Vector2 get_center() { }

	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	public float get_height() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public Vector2 get_max() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_min() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_position() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector2 get_size() { }

	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	public float get_width() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public float get_x() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_xMax() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public float get_xMin() { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_y() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yMax() { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_yMin() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public static Rect get_zero() { }

	[CalledBy(Type = typeof(CameraProperties), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VisibleLight), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	[CallerCount(Count = 0)]
	private static Rect OrderMinMax(Rect rect) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool Overlaps(Rect other, bool allowInverse) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Overlaps(Rect other) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_height(float value) { }

	[CallerCount(Count = 0)]
	public void set_max(Vector2 value) { }

	[CallerCount(Count = 0)]
	public void set_min(Vector2 value) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public void set_position(Vector2 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_size(Vector2 value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_width(float value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_x(float value) { }

	[CallerCount(Count = 0)]
	public void set_xMax(float value) { }

	[CallerCount(Count = 0)]
	public void set_xMin(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_y(float value) { }

	[CallerCount(Count = 0)]
	public void set_yMax(float value) { }

	[CallerCount(Count = 0)]
	public void set_yMin(float value) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


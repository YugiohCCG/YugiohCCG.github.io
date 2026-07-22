namespace UnityEngine;

[NativeClass("AABB")]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Bounds : IEquatable<Bounds>, IFormattable
{
	private Vector3 m_Center; //Field offset: 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; //Field offset: 0xC

	public Vector3 center
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 18
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 15
	}

	public Vector3 extents
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public Vector3 max
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		 set { } //Length: 147
	}

	public Vector3 min
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 61
		[CallerCount(Count = 0)]
		 set { } //Length: 148
	}

	public Vector3 size
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 45
		[CallerCount(Count = 0)]
		 set { } //Length: 48
	}

	[CallerCount(Count = 0)]
	public Bounds(Vector3 center, Vector3 size) { }

	[CalledBy(Type = "Extensions.CopyableCardText", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "HoveringBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = "Enumerator.DeckType")]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("IsInside", IsThreadSafe = True)]
	public bool Contains(Vector3 point) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Contains_Injected(ref Bounds _unity_self, in Vector3 point) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public void Encapsulate(Bounds bounds) { }

	[CallerCount(Count = 0)]
	public void Encapsulate(Vector3 point) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Bounds other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public Vector3 get_center() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector3 get_extents() { }

	[CallerCount(Count = 0)]
	public Vector3 get_max() { }

	[CallerCount(Count = 0)]
	public Vector3 get_min() { }

	[CallerCount(Count = 0)]
	public Vector3 get_size() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Intersects(Bounds bounds) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_center(Vector3 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_extents(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void set_max(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void set_min(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void set_size(Vector3 value) { }

	[CallerCount(Count = 0)]
	public void SetMinMax(Vector3 min, Vector3 max) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Event/Tracked Device Raycaster")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/TrackedInputDevices.html#tracked-device-raycaster")]
[RequireComponent(typeof(Canvas))]
public class TrackedDeviceRaycaster : BaseRaycaster
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<RaycastHitData> <>9__25_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "get_depth", ReturnType = typeof(int))]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal int <SortedRaycastGraphics>b__25_0(RaycastHitData g1, RaycastHitData g2) { }

	}

	private struct RaycastHitData
	{
		[CompilerGenerated]
		private readonly Graphic <graphic>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Vector3 <worldHitPosition>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private readonly Vector2 <screenPosition>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private readonly float <distance>k__BackingField; //Field offset: 0x1C

		public float distance
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 6
		}

		public Graphic graphic
		{
			[CallerCount(Count = 138)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public Vector2 screenPosition
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 19
		}

		public Vector3 worldHitPosition
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 19
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public RaycastHitData(Graphic graphic, Vector3 worldHitPosition, Vector2 screenPosition, float distance) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public float get_distance() { }

		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Graphic get_graphic() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Vector2 get_screenPosition() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Vector3 get_worldHitPosition() { }

	}

	internal static InlinedArray<TrackedDeviceRaycaster> s_Instances; //Field offset: 0x0
	private static readonly List<RaycastHitData> s_SortedGraphics; //Field offset: 0x18
	private List<RaycastHitData> m_RaycastResultsCache; //Field offset: 0x28
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; //Field offset: 0x30
	[FormerlySerializedAs("checkFor2DOcclusion")]
	[SerializeField]
	private bool m_CheckFor2DOcclusion; //Field offset: 0x31
	[FormerlySerializedAs("checkFor3DOcclusion")]
	[SerializeField]
	private bool m_CheckFor3DOcclusion; //Field offset: 0x32
	[SerializeField]
	[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
	private float m_MaxDistance; //Field offset: 0x34
	[SerializeField]
	private LayerMask m_BlockingMask; //Field offset: 0x38
	private Canvas m_Canvas; //Field offset: 0x40

	public LayerMask blockingMask
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	private Canvas canvas
	{
		[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 141
	}

	public bool checkFor2DOcclusion
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool checkFor3DOcclusion
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public virtual Camera eventCamera
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 121
	}

	public bool ignoreReversedGraphics
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float maxDistance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static TrackedDeviceRaycaster() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public TrackedDeviceRaycaster() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public LayerMask get_blockingMask() { }

	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private Canvas get_canvas() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_checkFor2DOcclusion() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_checkFor3DOcclusion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Camera get_eventCamera() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_ignoreReversedGraphics() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_maxDistance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRaycaster), Member = "OnDisable", ReturnType = typeof(void))]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRaycaster), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	protected virtual void OnEnable() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData)}, ReturnType = typeof(RaycastResult))]
	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider", ReturnType = typeof(Collider2D))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "SortedRaycastGraphics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster+RaycastHitData>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Physics2D), Member = "GetRayIntersection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(RaycastHit2D))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Graphic), Member = "get_depth", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "SortedRaycastGraphics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster+RaycastHitData>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_blockingMask(LayerMask value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_checkFor2DOcclusion(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_checkFor3DOcclusion(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ignoreReversedGraphics(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_maxDistance(float value) { }

	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicRegistry), Member = "GetGraphicsForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UI.Graphic>))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_depth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "RayIntersectsRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Ray), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster+RaycastHitData>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster+RaycastHitData>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<RaycastHitData> results) { }

}


namespace UnityEngine;

[AddComponentMenu("Rendering/Light Anchor")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class LightAnchor : MonoBehaviour
{
	private struct Axes
	{
		public Vector3 up; //Field offset: 0x0
		public Vector3 right; //Field offset: 0xC
		public Vector3 forward; //Field offset: 0x18

	}

	internal enum UpDirection
	{
		World = 0,
		Local = 1,
	}

	private const float k_ArcRadius = 5; //Field offset: 0x0
	private const float k_AxisLength = 10; //Field offset: 0x0
	internal const float k_MaxDistance = 10000; //Field offset: 0x0
	[Min(0)]
	[SerializeField]
	private float m_Distance; //Field offset: 0x20
	[SerializeField]
	private UpDirection m_FrameSpace; //Field offset: 0x24
	[SerializeField]
	private Transform m_AnchorPositionOverride; //Field offset: 0x28
	[SerializeField]
	private Vector3 m_AnchorPositionOffset; //Field offset: 0x30
	[SerializeField]
	private float m_Yaw; //Field offset: 0x3C
	[SerializeField]
	private float m_Pitch; //Field offset: 0x40
	[SerializeField]
	private float m_Roll; //Field offset: 0x44

	public Vector3 anchorPosition
	{
		[CalledBy(Type = typeof(LightAnchor), Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightAnchor), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightAnchor), Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 414
	}

	public Vector3 anchorPositionOffset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		 set { } //Length: 16
	}

	public Transform anchorPositionOverride
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float distance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 36
	}

	public UpDirection frameSpace
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float pitch
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 77
	}

	public float roll
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 77
	}

	public float yaw
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 77
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LightAnchor() { }

	[CalledBy(Type = typeof(LightAnchor), Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	public Vector3 get_anchorPosition() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 get_anchorPositionOffset() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Transform get_anchorPositionOverride() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_distance() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public UpDirection get_frameSpace() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_pitch() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_roll() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_yaw() { }

	[CalledBy(Type = typeof(LightAnchor), Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Matrix4x4), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_cameraToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float NormalizeAngleDegree(float angle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightAnchor), Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(LightAnchor), Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Axes))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrawGizmosSelected() { }

	[CallerCount(Count = 0)]
	public void set_anchorPositionOffset(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_anchorPositionOverride(Transform value) { }

	[CallerCount(Count = 0)]
	public void set_distance(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_frameSpace(UpDirection value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_pitch(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_roll(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_yaw(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightAnchor), Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(LightAnchor), Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Axes))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void SynchronizeOnTransform(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Transform), Member = "get_hasChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LightAnchor), Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(LightAnchor), Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Axes))]
	[Calls(Type = typeof(LightAnchor), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void Update() { }

	[CalledBy(Type = typeof(LightAnchor), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightAnchor), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightAnchor), Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Axes))]
	[Calls(Type = typeof(LightAnchor), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void UpdateTransform(Camera camera, Vector3 anchor) { }

}


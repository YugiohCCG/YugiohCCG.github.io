namespace UnityEngine.Jobs;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
public struct TransformAccess
{
	private IntPtr hierarchy; //Field offset: 0x0
	private int index; //Field offset: 0x8

	public Vector3 localScale
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 105
	}

	public Matrix4x4 localToWorldMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 147
	}

	public Vector3 position
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 105
	}

	public Quaternion rotation
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 93
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 get_localScale() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Matrix4x4 get_localToWorldMatrix() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 get_position() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem+UpdateTransformsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransformAccess)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public Quaternion get_rotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalScale(ref TransformAccess access, out Vector3 r) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

}


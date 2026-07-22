namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
public sealed class Gizmos
{

	public static Color color
	{
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.Core.PathCore.Path", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.PathCore.Path"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static Matrix4x4 matrix
	{
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawIcon_Injected(in Vector3 center, ref ManagedSpanWrapper name, bool allowScaling, in Color tint) { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "DrawGizmoCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.PathCore.Path", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.PathCore.Path"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawLine_Injected(in Vector3 from, in Vector3 to) { }

	[CalledBy(Type = "DG.Tweening.Plugins.Core.PathCore.Path", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.PathCore.Path"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static void DrawSphere(Vector3 center, float radius) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawSphere_Injected(in Vector3 center, float radius) { }

	[CalledBy(Type = "DG.Tweening.Plugins.Core.PathCore.Path", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.PathCore.Path"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DrawWireSphere_Injected(in Vector3 center, float radius) { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.PathCore.Path", Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.PathCore.Path"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_color(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_color_Injected(in Color value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_matrix(Matrix4x4 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_matrix_Injected(in Matrix4x4 value) { }

}


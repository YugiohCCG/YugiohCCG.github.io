namespace UnityEngine.UIElements;

internal static class ProjectionUtils
{

	[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) { }

}


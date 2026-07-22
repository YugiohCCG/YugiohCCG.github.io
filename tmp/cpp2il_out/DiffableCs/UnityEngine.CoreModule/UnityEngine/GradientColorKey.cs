namespace UnityEngine;

[UsedByNativeCode]
public struct GradientColorKey
{
	public Color color; //Field offset: 0x0
	public float time; //Field offset: 0x10

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public GradientColorKey(Color col, float time) { }

}


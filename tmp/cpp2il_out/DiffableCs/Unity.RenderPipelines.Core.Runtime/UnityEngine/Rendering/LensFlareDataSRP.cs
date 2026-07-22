namespace UnityEngine.Rendering;

public sealed class LensFlareDataSRP : ScriptableObject
{
	public LensFlareDataElementSRP[] elements; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public LensFlareDataSRP() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasAModulateByLightColorElement() { }

}


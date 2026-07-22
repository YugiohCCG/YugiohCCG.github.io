namespace UnityEngine.Rendering.LookDev;

public class StageRuntimeInterface
{
	private Func<Boolean, GameObject> m_AddGameObject; //Field offset: 0x10
	private Func<Camera> m_GetCamera; //Field offset: 0x18
	private Func<Light> m_GetSunLight; //Field offset: 0x20
	public object SRPData; //Field offset: 0x28

	public Camera camera
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 22
	}

	public Light sunLight
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 22
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public StageRuntimeInterface(Func<Boolean, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObject AddGameObject(bool persistent = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Camera get_camera() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Light get_sunLight() { }

}


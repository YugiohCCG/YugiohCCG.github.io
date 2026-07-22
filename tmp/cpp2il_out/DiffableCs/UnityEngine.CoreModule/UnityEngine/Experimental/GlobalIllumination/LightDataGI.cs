namespace UnityEngine.Experimental.GlobalIllumination;

[UsedByNativeCode]
public struct LightDataGI
{
	public int instanceID; //Field offset: 0x0
	public int cookieID; //Field offset: 0x4
	public float cookieScale; //Field offset: 0x8
	public LinearColor color; //Field offset: 0xC
	public LinearColor indirectColor; //Field offset: 0x1C
	public Quaternion orientation; //Field offset: 0x2C
	public Vector3 position; //Field offset: 0x3C
	public float range; //Field offset: 0x48
	public float coneAngle; //Field offset: 0x4C
	public float innerConeAngle; //Field offset: 0x50
	public float shape0; //Field offset: 0x54
	public float shape1; //Field offset: 0x58
	public LightType type; //Field offset: 0x5C
	public LightMode mode; //Field offset: 0x5D
	public byte shadow; //Field offset: 0x5E
	public FalloffType falloff; //Field offset: 0x5F

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Init(ref PointLight light, ref Cookie cookie) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Init(ref DirectionalLight light) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Init(ref PointLight light) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Init(ref SpotLight light) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public void InitNoBake(int lightInstanceID) { }

}


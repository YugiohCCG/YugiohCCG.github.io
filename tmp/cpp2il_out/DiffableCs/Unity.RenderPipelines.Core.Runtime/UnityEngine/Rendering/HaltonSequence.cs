namespace UnityEngine.Rendering;

public static class HaltonSequence
{

	[CalledBy(Type = typeof(STP), Member = "Jit16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(STP), Member = "PopulateConstantData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config&), typeof(StpConstantBufferData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "CalculateJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "CalculateFilterWeights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Settings&"}, ReturnType = "System.Single[]")]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	public static float Get(int index, int radix) { }

}


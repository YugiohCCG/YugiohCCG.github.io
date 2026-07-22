namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
public sealed class VolumeRequiresRendererFeatures : Attribute
{
	internal HashSet<Type> TargetFeatureTypes; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public VolumeRequiresRendererFeatures(Type[] featureTypes) { }

}


namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class MinAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x18

	[CalledBy(Type = "Unity.Properties.Internal.SystemVersionPropertyBag+MajorProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.SystemVersionPropertyBag+MinorProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.SystemVersionPropertyBag+BuildProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.SystemVersionPropertyBag+RevisionProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.SystemVersionPropertyBag", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MinAttribute(float min) { }

}


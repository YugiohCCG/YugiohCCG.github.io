namespace Spine.Unity;

[Extension]
public static class ISpineComponentExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsNullOrDestroyed(ISpineComponent component) { }

}


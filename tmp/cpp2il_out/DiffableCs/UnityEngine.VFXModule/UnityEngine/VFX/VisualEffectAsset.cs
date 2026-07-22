namespace UnityEngine.VFX;

[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[UsedByNativeCode]
public class VisualEffectAsset : VisualEffectObject
{
	public static readonly int PlayEventID; //Field offset: 0x0
	public static readonly int StopEventID; //Field offset: 0x4

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static VisualEffectAsset() { }

}


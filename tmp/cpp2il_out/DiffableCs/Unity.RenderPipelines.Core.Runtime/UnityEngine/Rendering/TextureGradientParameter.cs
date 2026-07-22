namespace UnityEngine.Rendering;

public class TextureGradientParameter : VolumeParameter<TextureGradient>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	public TextureGradientParameter(TextureGradient value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Release() { }

}


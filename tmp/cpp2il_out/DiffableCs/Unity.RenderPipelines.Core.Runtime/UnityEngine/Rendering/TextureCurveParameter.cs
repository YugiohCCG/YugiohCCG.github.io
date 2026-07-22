namespace UnityEngine.Rendering;

public class TextureCurveParameter : VolumeParameter<TextureCurve>
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorCurves", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	public TextureCurveParameter(TextureCurve value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCurve), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Release() { }

}


namespace DG.Tweening.Plugins;

public struct CircleOptions : IPlugOptions
{
	public float endValueDegrees; //Field offset: 0x0
	public bool relativeCenter; //Field offset: 0x4
	public bool snapping; //Field offset: 0x5
	internal Vector2 center; //Field offset: 0x8
	internal float radius; //Field offset: 0x10
	internal float startValueDegrees; //Field offset: 0x14
	internal bool initialized; //Field offset: 0x18

	[CalledBy(Type = typeof(CirclePlugin), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), typeof(Vector2), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CirclePlugin), Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Initialize(Vector2 startValue, Vector2 endValue) { }

	[CallerCount(Count = 0)]
	public override void Reset() { }

}


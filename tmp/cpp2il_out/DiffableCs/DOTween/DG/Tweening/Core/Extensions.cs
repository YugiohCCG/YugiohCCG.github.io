namespace DG.Tweening.Core;

[Extension]
public static class Extensions
{

	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableScaleBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableMoveBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableLocalMoveBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableRotateBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableLocalRotateBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendablePunchRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static TweenerCore<T1, T2, TPlugOptions> Blendable(TweenerCore<T1, T2, TPlugOptions> t) { }

	[CalledBy(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOTween), Member = "Punch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3[]), typeof(Single[])}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static TweenerCore<T1, T2, TPlugOptions> NoFrom(TweenerCore<T1, T2, TPlugOptions> t) { }

	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(AxisConstraint), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOTween), Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(DOTween), Member = "Punch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShakeAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(Vector2), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShakeAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(AxisConstraint), "System.Nullable`1<Vector3>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>")]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOShakeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetSpecialStartupMode(T t, SpecialStartupMode mode) { }

}


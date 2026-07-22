namespace UnityEngine;

public struct Ray : IFormattable
{
	private Vector3 m_Origin; //Field offset: 0x0
	private Vector3 m_Direction; //Field offset: 0xC

	public Vector3 direction
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 19
	}

	public Vector3 origin
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	public Ray(Vector3 origin, Vector3 direction) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector3 get_direction() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public Vector3 get_origin() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "RayIntersectsRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Ray), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_TextUtilities", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	public Vector3 GetPoint(float distance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AsymmetricSignatureDeformatter() { }

	public abstract void SetHashAlgorithm(string strName) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}


using ArchiSteamFarm.Helpers;

namespace ArchiSteamFarm.Extensions {
	public static class ArchiCryptoHelperExtension {
		public static string? Encrypt(ArchiCryptoHelper.ECryptoMethod cryptoMethod, string decryptedString) => ArchiCryptoHelper.Encrypt(cryptoMethod, decryptedString);

		public static void SetEncryptionKey(string key) => ArchiCryptoHelper.SetEncryptionKey(key);
	}
}

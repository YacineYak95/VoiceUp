namespace Todo
{
	public static class Constants
	{
		public static readonly string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";

		public static readonly string BingSpeechApiKey = "78e60a1235d346f4a2a5ae14e4d477f7";
		public static readonly string SpeechRecognitionEndpoint = "https://speech.platform.bing.com/recognize";
		public static readonly string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";

		public static readonly string BingSpellCheckApiKey = "3f49e2da29bc4f4290bba6d0e54faac5";
		public static readonly string BingSpellCheckEndpoint = "https://api.cognitive.microsoft.com/bing/v5.0/spellcheck/";

		public static readonly string TextTranslatorApiKey = "bbf7fc9e982941bc8ac373be9e49499b";
		public static readonly string TextTranslatorEndpoint = "https://api.microsofttranslator.com/v2/http.svc/Translate";

		public static readonly string EmotionApiKey = "96fee6b149474946a1c041a709db672f";

		public static readonly string AudioFilename = "Todo.wav";
	}
}

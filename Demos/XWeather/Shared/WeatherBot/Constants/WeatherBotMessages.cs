﻿namespace XWeather.WeatherBot
{
	public static class WeatherBotMessages
	{
		public const string ParsingFeedbackMsg = "Parsing request...";
		public const string NotUnderstoodResponse = "Sorry, I wasn't able to understand your request";
		public const string NotUnderstoodResponseTemplate = "Sorry, I don't know anything about {0}";
		public const string NoLocationResponse = "Sorry, I didn't hear a location in your query. I can check the weather, but I need a location to check.";
		public const string IrritatedResponseTemplate = "Dammit, I'm a weather bot, I can't do those cheap tricks!";
		public const string CheckWeatherResponseTemplate = "Ok, checking current weather for {0}";
		public const string CheckWeatherForecastResponseTemplate = "Ok, checking the {0} weather forecast for {1}";
		public const string CheckFutureWeatherForecastResponseTemplate = "Ok, checking the weather for {0} {1}";
	}
}
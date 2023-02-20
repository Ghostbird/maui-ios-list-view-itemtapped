﻿using Microsoft.Extensions.Logging;

namespace list_view_itemtapped;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

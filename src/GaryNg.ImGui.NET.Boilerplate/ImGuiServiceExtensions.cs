using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace GaryNg.ImGui.NET.Boilerplate;

public static class ImGuiServiceExtensions
{
	public static IServiceCollection AddImGuiNET(this IServiceCollection services, Action<ImGuiHostWindowOptions, IServiceProvider>? configure = null)
	{
		services.TryAddSingleton<IImGuiHostWindow>(provider =>
		{
			var options = new ImGuiHostWindowOptions();
			configure?.Invoke(options, provider);
			var window = new ImGuiHostWindow(options);
			return window;
		});
		return services;
	}
}
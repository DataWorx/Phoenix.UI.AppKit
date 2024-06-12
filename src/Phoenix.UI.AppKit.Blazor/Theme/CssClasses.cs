namespace Phoenix.UI.AppKit.Blazor.Theme;

public class ThemeCss
{
    public static string PrimaryForeground = "orange-text text-darken-3";

    public static string AddClasses(params string[] classes) => string.Join(" ", classes);
}
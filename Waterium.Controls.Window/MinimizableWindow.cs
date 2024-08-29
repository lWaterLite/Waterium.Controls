using System.Windows;
using System.Windows.Input;

namespace Waterium.Controls.Window;

public class MinimizableWindow : System.Windows.Window
{
    static MinimizableWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizableWindow),
            new FrameworkPropertyMetadata(typeof(MinimizableWindow)));
    }

    protected MinimizableWindow()
    {
        CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand,
            (_, _) => SystemCommands.CloseWindow(this)));
        CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand,
            (_, _) => SystemCommands.MinimizeWindow(this)));
    }
}

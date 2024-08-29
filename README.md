# Waterium.Controls

[![Waterium.Controls](https://img.shields.io/badge/Waterium.Controls-%40lWaterLite-blue)](https://github.com/lWaterLite) [![.Net](https://img.shields.io/badge/.NET-8.0-green)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

Waterium.Controls is a custom control library for WPF desktop application.

## Install

1. Download the [Latest release](https://github.com/lWaterLite/Waterium.Iconfont/release), and unzip it at any directory you like.
2. Open your own project, and add reference to the `.dll` file.
3. References should be solved by your using IDE.

## Usage

In your `App.xaml` file, add a namespace as following

```xaml
xmlns:wtr="clr-namespace:Waterium.Controls.Window;assembly=Waterium.Controls.Window
```

Notice that `Window` should be replaced by the correct namespace you are using.

Then in your window, you can add the control

```xaml
<wtr:ResizableWindow />
```

## Resource

Available namespaces and controls are as following:

- Window
  - ResizableWindow
  - MinimizableWind


## License

[MIT](LICENSE) @ 2024 lWaterLite
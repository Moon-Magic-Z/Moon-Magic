using System; using System.Diagnostics; using ImGuiNET; using Dalamud.Interface.Windowing; using Dalamud.Plugin;
namespace MoonMagic.Ui {
public sealed class MainWindow : Window {
    private readonly IDalamudPluginInterface _pi;
    public MainWindow(IDalamudPluginInterface pi) : base("Moon Magic") { _pi = pi; }
    public override void Draw() { DrawDonateButtonTopRight(); }
    private void DrawDonateButtonTopRight() {
        var label = "Donate";
        if (ImGui.Button(label)) {
            try {
                var psi = new ProcessStartInfo("https://ko-fi.com/moonmagicz") { UseShellExecute = true };
                Process.Start(psi);
            } catch {}
        }
        ImGui.NewLine();
    }
}}
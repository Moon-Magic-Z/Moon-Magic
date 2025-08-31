# Moon-Magic
Behold! You and your friends can see one another's looks!

https://raw.githubusercontent.com/Moon-Magic-Z/Moon-Magic/main/repo.json

# 🌙 Moon Magic

Moon Magic is an **all-in-one Dalamud plugin** for Final Fantasy XIV that unifies common modding workflows into a single interface:

- 🧥 **Wardrobe Conflicts** – See all Penumbra mods that overlap on the same gear/asset, with simple toggles to switch which one takes precedence.  
- ✨ **Glamours** – One-click switching between Glamourer designs, overriding automation so you can quickly change outfits in game.  
- 🔑 **Moon Keys & Communities** – Share your appearance with friends or groups (like Mare/Snowcloak), but client-side and under your control.  
- 📥 **Importer** – Optional migration tool for Mare/Snowcloak users. Reads local `pluginConfigs` only — no remote calls.  
- ✅ **Consent Modal** – First run shows Terms of Use (EULA/ToS). Users must type **I AGREE** before continuing.  
- 💜 **Donate Button** – A purple “Donate” button (top-right of the plugin window) links directly to [Ko‑fi](https://ko-fi.com/moonmagicz).  

Moon Magic is a **learning project**: it integrates and orchestrates existing plugin IPCs (Penumbra, Glamourer, Customize+, Heels+), but does not modify the FFXIV client or servers.  

---

## 🚀 Features

- **Wardrobe (Penumbra Integration)**  
  - Detects conflicting mods (same base gear/vpaths).  
  - Toggle mods on/off without reordering Penumbra manually.  
  - Inspect and copy virtual paths for debugging.  
  - UI highlights active mod, inactive conflicts, and priority order.  

- **Glamours (Glamourer Integration)**  
  - Lists all saved Glamourer designs.  
  - One-click to apply → automatically disables other active designs.  
  - Option to auto-reapply on zone change/login.  

- **Moon Keys & Communities**  
  - Each user has a unique **Moon Key**.  
  - Add friends or join communities with codes (`MM-Name`).  
  - Options to mute, leave, or ban.  
  - Optional Carrd link per key (DNS-verified carrd.co only).  

- **Migration**  
  - Import Mare/Snowcloak data (keys, groups) from your **local** plugin configs.  
  - Preview before committing.  
  - Independent — Moon Magic is not a fork and does not depend on Mare servers.  

- **Consent Modal**  
  - Enforces typed **I AGREE** acceptance of ToS/EULA.  
  - Stored locally with version + hash.  
  - Prompts again if terms change.  

---

## 🛠 Installation

### Development Build

1) Install **.NET 9 SDK**.  
2) Open `MoonMagic/MoonMagic.csproj` in Visual Studio (Release | x64).  
3) Build → output copies automatically to:

       %APPDATA%/XIVLauncher/devPlugins/MoonMagic

4) In XIVLauncher (Testing/Dev channel) → Dalamud Settings → enable **Developer Plugins**.  
5) In-game: `/xlplugins` → Installed → **Moon Magic**, or run `/moonmagic`.
   

### Public Release
- When a GitHub Release is tagged (`v0.1.0`, `v0.1.1`, etc.), CI builds and uploads `latest.zip`.  
- Add this URL to Dalamud → Settings → Experimental → Custom Plugin Repositories:  
  ```
  https://raw.githubusercontent.com/<your-handle>/<repo>/main/repo.json
  ```
- Install **Moon Magic** from the plugin installer.

---

## 🔐 Privacy & Security

- **No telemetry.**  
- **No personal data.**  
- **No IP collection.**  
- **Client-side only.** Uses IPC calls with Penumbra/Glamourer/Customize+/Heels+.  
- Configs and keys are stored **locally**.  

---

## ⚠️ Disclaimer

Moon Magic is an **independent third-party plugin**.  
- It is **not affiliated with Square Enix**.  
- Use of this plugin may violate Square Enix’s Terms of Service. Use at your own risk.  
- Moon Magic is primarily a **learning project**, provided *as-is*, with no warranties.  

---

## 💜 Support

If you’d like to support development, click the purple **Donate** button in the plugin, or visit:  
👉 [Ko‑fi.com/moonmagicz](https://ko-fi.com/moonmagicz)

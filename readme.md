# DotNetSampleApp

- Create directory & change to it
- Run `git init`
- Manually created `.vscode` directory and `settings.json`
- Added entry for:

```json
{
    "window.zoomlevel": 2
}
```

- And immediately noted that it took effect
- Updated `settings.json` as follows:

```json
{
    "editor.formatOnSave": true,
    "window.zoomLevel": 2,
    "terminal.integrated.defaultProfile.windows": "Git Bash"
}
```

- New terminal: `Control+Shift+{BACKTICK}`
- From project root directory:

```text
dotnet new console -o src/DotNetSampleApp
```

- And run with:

```text
dotnet run --project src/DotNetSampleApp
```



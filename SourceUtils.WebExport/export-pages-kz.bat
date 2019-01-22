@echo off

dotnet "bin\Debug\netcoreapp2.2\SourceUtils.WebExport.dll" export ^
	--maps "kz_reach_v2" ^
	--outdir "exports" ^
	--gamedir "F:\SteamLibrary\steamapps\common\Counter-Strike Global Offensive\csgo" ^
	--mapsdir "maps" ^
	--overwrite --verbose --url-prefix "/resources/csgo"


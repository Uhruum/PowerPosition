# PowerPosition

PowerPosition is windows service. 
Generates csv reports on specified frequency with data provided from PowerService.

## Dependencies
Project uses Autofac, Log4net, CsvHelper

### Setup
1. Download project
2. Build it
3. Go to ..\PowerPosition\Presentation\bin\Debug
4. Open App.config in txt editor
5. Change the values of these two properties **PathToCsvFolder** and **RuntimeFrequencyInMin**
6. Save changes and close txt editor

### Installation
1. Open cmd with admin priviliges
2. Navigate to the C:\Windows\Microsoft.NET\Framework\v4.0.30319
3. Execute InstallUtil.exe ..\PowerPosition\Presentation\bin\Debug\Presentation.exe --full path to exe needs to be specified ../ is just placeholder

### Running service
1. Press window + R keys
2. Type services.msc
3. Find PowerPositionReportService
4. Click run

### Enviroment
1. Log shoud be in ..\PowerPosition\Presentation\bin\Debug
2. Reports shoud be in path specified **PathToCsvFolder**

### Uninstalling
1. Press window + R keys
2. Type services.msc
3. Find PowerPositionReportService
4. Stop service
5. Open cmd with admin priviliges
6. Navigate to the C:\Windows\Microsoft.NET\Framework\v4.0.30319
7. Execute InstallUtil.exe -u ..\PowerPosition\Presentation\bin\Debug\Presentation.exe --full path to exe needs to be specified ../ is just placeholder

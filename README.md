# log4net.RollingFileByMaxAgeAppender
A RollingFile Appender for log4net that deletes old logfiles

## NuGet Package
This appender is available as a [NuGet package](https://www.nuget.org/packages/Net.Bluewalk.log4net.RollingFileByMaxAgeAppender/).

Run `Install-Package Net.Bluewalk.log4net.RollingFileByMaxAgeAppender` in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console) or search for "RollingFileByMaxAgeAppender" in your IDE's package management plug-in.

## Usage
Configure your log4net appender to the type
```xml
<appender name="file" type="Net.Bluewalk.log4net.RollingFileByMaxAgeAppender.RollingFileByMaxAgeAppender, Net.Bluewalk.log4net.RollingFileByMaxAgeAppender">
```

You can then use the `maxSizeRollBackups` property to define how many logfiles need to be retained.

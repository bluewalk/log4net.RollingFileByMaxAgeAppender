using System;
using System.IO;
using System.Linq;
using log4net.Appender;

namespace Net.Bluewalk.log4net.RollingFileByMaxAgeAppender
{
    public class RollingFileByMaxAgeAppender : RollingFileAppender
    {
        protected override void AdjustFileBeforeAppend()
        {
            base.AdjustFileBeforeAppend();

            if (RollingStyle != RollingMode.Date) return;
            
            Directory.GetFiles(Path.GetDirectoryName(File), $"*{Path.GetFileNameWithoutExtension(File)}*{Path.GetExtension(File)}*")
                .ToList()
                .ForEach(f =>
                {
                    if (System.IO.File.GetLastWriteTime(f) < DateTime.Today.AddDays(-1 * MaxSizeRollBackups))
                        DeleteFile(f);
                });
        }
    }
}

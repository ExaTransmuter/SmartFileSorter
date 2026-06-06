using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SmartFileSorter
{
public class ReportGenerator
{
public void Generate(string outputPath, List<string> files)
{
StringBuilder report = new();

```
        report.AppendLine("SmartFileSorter Report");
        report.AppendLine($"Generated: {DateTime.Now}");
        report.AppendLine();

        foreach (var file in files)
        {
            report.AppendLine(file);
        }

        File.WriteAllText(outputPath, report.ToString());
    }
}
```

}

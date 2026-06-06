using System;
using System.Collections.Generic;
using System.IO;

namespace SmartFileSorter
{
public class FileScanner
{
public List<string> ScanFolder(string path)
{
List<string> files = new();

```
        if (!Directory.Exists(path))
            return files;

        files.AddRange(Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly));

        return files;
    }
}
```

}

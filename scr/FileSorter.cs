using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SmartFileSorter
{
public class FileSorter
{
private readonly List<SortingRule> _rules;

```
    public FileSorter(List<SortingRule> rules)
    {
        _rules = rules;
    }

    public string GetCategory(string filePath)
    {
        string extension = Path.GetExtension(filePath).ToLower();

        foreach (var rule in _rules)
        {
            if (rule.Extensions.Contains(extension))
                return rule.Category;
        }

        return "Other Files";
    }
}
```

}

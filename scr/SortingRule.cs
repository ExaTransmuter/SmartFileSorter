using System.Collections.Generic;

namespace SmartFileSorter
{
public class SortingRule
{
public string Category { get; set; }

```
    public List<string> Extensions { get; set; }

    public SortingRule(string category, List<string> extensions)
    {
        Category = category;
        Extensions = extensions;
    }
}
```

}

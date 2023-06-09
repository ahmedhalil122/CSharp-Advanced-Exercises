
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString;

public class Box<T>
{
    List<T> item = new List<T>();

    public void Add(T element)
    {
        item.Add(element);
    }

    public override string ToString()
    {
       StringBuilder sb = new StringBuilder();
        foreach (T element in item)
        {
            sb.AppendLine($"{typeof(Int32)}: {element}");
        }
            return sb.ToString();
    }
}

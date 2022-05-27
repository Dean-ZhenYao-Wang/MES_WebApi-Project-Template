using System;
using System.Collections;
using System.Collections.Generic;

public class SelectionList : IDictionary<int, string>
{
    public string this[int key] { get => ((IDictionary<int, string>)Selections)[key]; set => ((IDictionary<int, string>)Selections)[key] = value; }

    public Guid Id { get; set; }
    public Dictionary<int, string> Selections { get; set; } = new Dictionary<int, string>();

    public ICollection<int> Keys => ((IDictionary<int, string>)Selections).Keys;

    public ICollection<string> Values => ((IDictionary<int, string>)Selections).Values;

    public int Count => ((IDictionary<int, string>)Selections).Count;

    public bool IsReadOnly => ((IDictionary<int, string>)Selections).IsReadOnly;

    public void Add(int key, string value)
    {
        ((IDictionary<int, string>)Selections).Add(key, value);
    }

    public void Add(KeyValuePair<int, string> item)
    {
        ((IDictionary<int, string>)Selections).Add(item);
    }

    public void Clear()
    {
        ((IDictionary<int, string>)Selections).Clear();
    }

    public bool Contains(KeyValuePair<int, string> item)
    {
        return ((IDictionary<int, string>)Selections).Contains(item);
    }

    public bool ContainsKey(int key)
    {
        return ((IDictionary<int, string>)Selections).ContainsKey(key);
    }

    public void CopyTo(KeyValuePair<int, string>[] array, int arrayIndex)
    {
        ((IDictionary<int, string>)Selections).CopyTo(array, arrayIndex);
    }

    public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
    {
        return ((IDictionary<int, string>)Selections).GetEnumerator();
    }

    public bool Remove(int key)
    {
        return ((IDictionary<int, string>)Selections).Remove(key);
    }

    public bool Remove(KeyValuePair<int, string> item)
    {
        return ((IDictionary<int, string>)Selections).Remove(item);
    }

    public bool TryGetValue(int key, out string value)
    {
        return ((IDictionary<int, string>)Selections).TryGetValue(key, out value);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IDictionary<int, string>)Selections).GetEnumerator();
    }
}
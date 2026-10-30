public class MyHashSet {

    public List<int> list {get; set;}

    public MyHashSet() {
        list = new List<int>();
    }
    
    public void Add(int key) {
        if(!list.Any(x => x == key))
            list.Add(key);
    }
    
    public void Remove(int key) {
        list.Remove(key);
    }
    
    public bool Contains(int key) {
        return list.Any(x => x == key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
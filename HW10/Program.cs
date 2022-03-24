using HW10Library;
MyItem item1 = new MyItem(1);
MyItem item2 = new MyItem(2);
MyItem item3 = new MyItem(3);
MyItem item4 = new MyItem(4);
MyItem item5 = new MyItem(5);
MyList myItems = new MyList();

myItems.Add(item1);
myItems.Add(item2);
myItems.Add(item3);
myItems.Add(item4);
myItems.Add(item5);

myItems.Clear();

myItems.Add(item1);
myItems.Add(item2);
myItems.Add(item3);
myItems.Add(item4);
myItems.Add(item5);

var isContains = myItems.Contains(item1);

MyItem[] items = new MyItem [5];

myItems.CopyTo(items, 0);

int index = myItems.IndexOf(item3);

MyItem item6 = new MyItem (6);

myItems.Insert(2, item6);
myItems.RemoveAt(2);
myItems.Remove(item2);

myItems.Add(item6);

int a = myItems.Count;
foreach (var item in myItems)
{
    Console.WriteLine(item.number);
}
Console.ReadLine();
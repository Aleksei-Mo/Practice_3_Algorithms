
LinkedList list = new LinkedList (); // создаем новый объект типа LinkedList

list.AddFirst(1);//добавляем первый элемент
//list.AddFirst(2);
//list.AddFirst(3);
//list.AddFirst(4);
//list.AddFirst(5);
//Console.WriteLine(list.head.val + " "+ list.head.next.val);
//list.RemoveFirst();
list.ReverseList(list);
Console.WriteLine(list.head.val + " "+ list.head.next.val);
public class LinkedList // определяем класс для односвязного списка
{
    public Node? head; // определяем головной (первый) элемент
    public Node? tail; // определяем хвостовой (последний) элемент


    public void AddFirst(int val) // определяем метод добавления первого элемента
    {
        Node node = new Node(val);

        if (head == null)// если список пустой, то head  и tail имеют одинаковое значение
            head = node;
        else
            tail.next = node;
        tail = node;
    }

    public void RemoveFirst() //определяем метод удаления первого элемента
    {
        head = head.next;
        if (head == null)
        { // если после удаления первого элемента список пуст,то обнуляем tail
            tail = null;
        }
    }

    public void ReverseList(LinkedList list)
    {
        if ((head == null) || (head.next == null))
        {
            Console.WriteLine("Warning! You don't need to reverse your list.");
        }
        else
        {
            Node? node = list.head;//safe current head value
            Node? previousNode = null;// this is oneway list -> previous ref = nul
            while (node != null)
            {
                Node? tempNode = node.next;//safe current head.next value
                node.next = previousNode;
                previousNode = node;
                list.head = node;
                node = tempNode;
            }
        }
    }
}
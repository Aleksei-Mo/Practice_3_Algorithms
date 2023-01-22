public class Node // создаем класс элемента списка
{
   public Node? next; // обЪявляем поля
   public int val;

// определяем три конструктора для данного класса
   public Node()
    {
    }
    public Node(int val)
    {
        this.val = val;
    }
   public Node(int val, Node next)
    {
        this.val = val;
        this.next = next;
    }
   
}
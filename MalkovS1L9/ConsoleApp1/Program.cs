using lab9;
namespace Prog
{
    class P
    {
        static void Main()
        { 
            MyLinkedList<string> linkedList = new MyLinkedList<string>();
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("John");
            linkedList.Add("Marry");


            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList.Remove("Alice");
            Console.WriteLine("\nПосле удаления Alice");
            foreach (var item in linkedList) Console.WriteLine(item);

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Bill");
            Console.WriteLine("\nПосле добавления Billa");
            foreach (var item in linkedList) Console.WriteLine(item);
        }
    }
}
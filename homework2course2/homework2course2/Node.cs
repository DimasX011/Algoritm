using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2course2
{
    public class Node
    {
        public int Value { get; set; }//значение ноды
        public Node NextNode { get; set; }//следующая нода
        public Node PrevNode { get; set; }//предыдущая нода
    }
    public interface ILinkedList
    {
        int GetCount();// возврат количества элементов в списке
        void addNote(int value);//добавление нового элемента списка
        void AddNodeAfter(Node node, int value);//добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index);//удаляет элемент по порядковому номеру
        void RemoveNode(Node node);//удаляет указанный элемент
        Node FindNode(int searchValue);//ищет элемент по его значению
    }



}

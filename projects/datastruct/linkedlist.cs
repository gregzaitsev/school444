using System;

class LinkedNode {
  public int n;
  public LinkedNode next;
}

interface ILinkedList {
  void Sort();
  void InsertAfter(int after, int n);
}

// Выше этой строки ничего менять нельзя
/////////////////////////////////////////////////

// Задачи:
// 1. Реализовать конструктор связанного списка, который будет принимать массив 
//    чисел как параметр и создавать из него связанный список
// 2. Реализовать метод InsertAfter, который будет вставлять элемент в связанный 
//    список после элемента с порядковым номером after
// 3. Реализовать метод Sort, который будет сортировать связанный список по 
//    возрастанию методом пузырька без использования массивов и встроенных 
//    методов сортировки

class LinkedList : ILinkedList {

  LinkedNode first;

  // Конструктор
  public LinkedList(int[] numbers) {
    //first = new LinkedNode();
  }

  public LinkedNode getFirst() {
    return first;
  }

  public void Sort() {}

  public void InsertAfter(int after, int n) {}

}

/////////////////////////////////////////////////
// Ниже этой строки ничего менять нельзя

class MainClass {
  public static LinkedList myList;

  public static void InitList() {
    myList = new LinkedList(new int[] {6, 5, 3, 5, 7, 9, 0});
  }

  public static void Output() {
    LinkedNode node = myList.getFirst();
    while (node != null) {
      Console.WriteLine("" + node.n);
      node = node.next;
    }
  }

  public static void Main (string[] args) {
    InitList();
    Console.WriteLine ("Элементы связанного списка:");
    Output();

    Console.WriteLine ("Элементы связанного списка после вставки:");
    myList.InsertAfter(1, 100);
    Output();

    Console.WriteLine ("Элементы связанного списка после сортировки:");
    myList.Sort();
    Output();
  }
}